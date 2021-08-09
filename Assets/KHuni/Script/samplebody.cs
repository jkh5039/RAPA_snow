using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class samplebody : MonoBehaviour
{
    //�� script�� enemy ���� ���� �ִ´�????????
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
        //���� �ִϸ��̼�
    }

    void ThrowAnimation()
    {
        //�������� ������ �ִϸ��̼�
    }
    void WalkAnimation()
    {
        //������� �ȴ� �ִϸ��̼�
    }

    void Die()
    {
        Destroy(gameObject, 2f); //anmation event �˻��غ���
        //�ı��ϱ�
    }
    #region ������
    //private void OnCollisionEnter(Collision collision) //�Ѿ˰� �浹�� �˸�
    //{
    //    if (other.gameObject.name.Contains("bullet") == false)
    //    {
    //        print("�浹");

    //        HpDamage(1);
    //    }
    //}
    #endregion
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("bullet") == false)
        {
            print("�浹");

            HpDamage(1);
            Destroy(other.gameObject);
        }
    }


    #region ������
    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.gameObject.name.Contains("bullet") == false)
    //    {
    //        print("�浹");
    //        HpDamage(1);
    //    }
    //}
    #endregion
}
