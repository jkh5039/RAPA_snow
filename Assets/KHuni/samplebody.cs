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
        //�Է¸��ް��Ѵ�
        if (isStun)
        {
            timer = Time.deltaTime;
            if (stuntime <= timer)
                StunAnimationStop();
            return;
        }
        //3�ʵ���
        //�Է��� ������ �ִ�
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
        Destroy(gameObject, 2f); //anmation event �˻��غ���
        //�ı��ϱ�
    }

    private void OnTriggerEnter(Collider other) //�Ѿ˰� �浹�� �˸�
    {
        if (other.gameObject.name.Contains("bullet") == false)
        {
            print("�浹");
            HpDamage(1);
        }
    }
}
