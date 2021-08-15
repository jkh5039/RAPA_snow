using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    //���� ������ ���� �� �ϴ� �����.... //0809
    public int hp=2;
    public float stuntime = 3.0f;
    public float wakeuptime = 3.0f;
    public bool isStun;
    public float timer;
    public Animator animator;

    //Camera  ���ӿ�����Ʈ
    public GameObject camObj;
    //Camera ������Ʈ
    Camera cam;
    //�浹�ϰ� �������� Layer
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
        if (isStun)   //����������
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

        //ȭ�� ���콺 ��ǥ���� �߻�Ǵ� Ray�� �����.
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
            //Ray�߻�!!

            if (Physics.Raycast(ray, out hitInfo, 1000, layer1))
            {
                Vector3 vec = new Vector3(hitInfo.point.x, hitInfo.point.y + 1.7f, hitInfo.point.z);
                transform.position = vec;
            }
        }
    }

    //#region 0809���������͵� kc ��
    //void StunAnimationStop()  //samplebody���� �Ʒ� �� ���� ������
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
        //3�ʵ� �Ͼ��(������)
        float nowtime = 0;
        nowtime += Time.deltaTime;
        if (nowtime >= wakeuptime)
        {
            //���� �ִϸ��̼�
            animator.SetBool("Stun", false);
            nowtime = 0;
        }
    }
    void Die()
    {
        print("Die");
        animator.SetTrigger("Die");
        Destroy(gameObject, 2f); //anmation event �˻��غ���
        //�ı��ϱ�
    }
    //#region ������
    ////private void OnCollisionEnter(Collision collision) //�Ѿ˰� �浹�� �˸�
    ////{
    ////    if (other.gameObject.name.Contains("bullet") == false)
    ////    {
    ////        print("�浹");

    ////        HpDamage(1);
    ////    }
    ////}
    //#endregion

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Snow")) //bullet �̸��� �ٲ㺻��,,,
        {
            print("�浹");

            HpDamage(1);
            Destroy(other.gameObject);
        }
    }
    //#endregion
}
