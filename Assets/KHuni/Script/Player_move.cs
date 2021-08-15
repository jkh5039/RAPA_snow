using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    //내가 공격을 당할 때 일단 적어둠.... //0809
    public int hp=2;
    public float stuntime = 3.0f;
    public float wakeuptime = 3.0f;
    public bool isStun;
    public float timer;
    public Animator animator;

    //Camera  게임오브젝트
    public GameObject camObj;
    //Camera 컴포넌트
    Camera cam;
    //충돌하고 싶지않은 Layer
    public LayerMask layer;
    public LayerMask layer1;
    public GameObject snowFactory; 
    public GameObject snowPos;
    

    public bool isPlayerClick;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        //int hp = 2;
    }
    float currTime = 0f;
    float motionTime = 1.5f;
    float stunTimer = 0f;
    float stunTime = 2f;
    // Update is called once per frame
    void Update()
    {
        if (isStun)   //새로적은거
        {
            stunTimer += Time.deltaTime;
            if (stunTimer >= stunTime)
            {
                stunTimer = 0f;
                isStun = false;
                animator.SetTrigger("Stun");
            }
            return;
        }

        //화면 마우스 좌표에서 발사되는 Ray를 만든다.
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hitInfo, 1000, layer))
            {
                //isPlayerClick = true;
                //animator.SetBool("Run", true);
                //isPlayerClick = true;
                Player_move pm = hitInfo.transform.GetComponent<Player_move>();
                pm.isPlayerClick = true;
                pm.animator.SetBool("Run", true);
            }
        }

        currTime += Time.deltaTime;

        if (Input.GetButtonUp("Fire1") && isPlayerClick)
        {
            GameObject snow = Instantiate(snowFactory);
            snow.transform.position = snowPos.transform.position;
            Destroy(snow, 1.5f);
            animator.SetBool("Run", false);
            animator.SetBool("Attack", true);
            isPlayerClick = false;
        }

        if (currTime > motionTime)
        {
            animator.SetBool("Attack", false);
            currTime = 0f;
        }

        if (isPlayerClick)
        {
            //Ray발사!!

            if (Physics.Raycast(ray, out hitInfo, 1000, layer1))
            {
                Vector3 vec = new Vector3(hitInfo.point.x, hitInfo.point.y + 1.7f, hitInfo.point.z);
                transform.position = vec;
            }
        }
    }

    //#region 0809새로적은것들 kc 함
    //void StunAnimationStop()  //samplebody에서 아래 쭉 까지 가져옴
    //{
    //    timer = 0f;
    //    isStun = false;
    //}

    void HpDamage(int amount)
    {
        animator.SetBool("Run", false);

        hp -= amount;
        print("Damage Hp : " + hp);

        if (hp == 1)
        {
            Stun();
        }
        else if (hp == 0)
        {
            Die();
        }
    }
    void Stun()
    {
        print("Stun");

        animator.SetTrigger("Stun");
        isStun = true;
        //StunAnimation();
    }
    void StunAnimation()
    {
        print("StunAnim");
        //3초뒤 일어선다(원상태)
        float nowtime = 0;
        nowtime += Time.deltaTime;
        if (nowtime >= wakeuptime)
        {
            //스턴 애니메이션
            animator.SetBool("Stun", false);
            nowtime = 0;
        }
    }
    void Die()
    {
        print("Die");
        animator.SetTrigger("Die");
        Destroy(gameObject, 2f); //anmation event 검색해본다
        //파괴하기
    }
    //#region 연습장
    ////private void OnCollisionEnter(Collision collision) //총알과 충돌시 알림
    ////{
    ////    if (other.gameObject.name.Contains("bullet") == false)
    ////    {
    ////        print("충돌");

    ////        HpDamage(1);
    ////    }
    ////}
    //#endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Snow")) //bullet 이름을 바꿔본다,,,
        {
            print("충돌");

            HpDamage(1);
            Destroy(other.gameObject);
        }
    }
    //#endregion
}
