using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplebody : MonoBehaviour
{
    public int hp;
    // Start is called before the first frame update
    void Start()
    {
        hp = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void HpDamage(int amount)
    {
        hp -= amount;
        
        switch(hp)
        {
            case 0:
                Stun();
                break;
            case 1:
                Die();
                
                break;
            default:
                break;
        }
    }

    void Stun()
    {
        //입력못받게하는거
    }

    void Die()
    {
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
