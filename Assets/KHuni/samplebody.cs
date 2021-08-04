using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplebody : MonoBehaviour
{
    public int hp;
    public float stuntime = 3.0f;
    public bool isStun;
    public float timer;
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

    }

    void Die()
    {
        Destroy(gameObject, 2f); //anmation event 검색해본다
        //파괴하기
    }

    private void OnTriggerEnter(Collider other) //총알과 충돌시 알림
    {
        if (other.gameObject.name.Contains("bullet") == false)
        {
            print("충돌");
            HpDamage(1);
        }
    }
}
