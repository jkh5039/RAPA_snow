using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplebody : MonoBehaviour
{
    //이 script는 enemy 한테 끼워 넣는다????????
    public int hp;
    public float stuntime = 3.0f;
    public bool isStun;
    public float timer;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        hp = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //입력못받게한다
        if (isStun)
        {
            timer = Time.deltaTime;
            if (stuntime <= timer)
                StunAnimationStop();
            return;
        }
        //3초동안
        //입력을 받을수 있다
    }

    void StunAnimationStop()
    {
        timer = 0f;
        isStun = false;
    }

    void HpDamage(int amount)
    {
        hp -= amount;

       
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
        isStun = true;
        StunAnimation();

        
    }
    void StunAnimation()
    {
        //스턴 애니메이션
    }

    void ThrowAnimation()
    {
        //놓았을떄 던지는 애니메이션
    }
    void WalkAnimation()
    {
        //잡았을때 걷는 애니메이션
    }

    void Die()
    {
        Destroy(gameObject, 2f); //anmation event 검색해본다
        //파괴하기
    }
    #region 연습장
    //private void OnCollisionEnter(Collision collision) //총알과 충돌시 알림
    //{
    //    if (other.gameObject.name.Contains("bullet") == false)
    //    {
    //        print("충돌");

    //        HpDamage(1);
    //    }
    //}
    #endregion
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("bullet") == false)
        {
            print("충돌");

            HpDamage(1);
            Destroy(other.gameObject);
        }
    }


    #region 연습장
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name.Contains("bullet") == false)
    //    {
    //        print("충돌");
    //        HpDamage(1);
    //    }
    //}
    #endregion
}
