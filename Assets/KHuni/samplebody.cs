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
        //�Է¸��ް��ϴ°�
    }

    void Die()
    {
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
