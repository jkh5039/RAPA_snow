using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{

    //�ѱ�
    public GameObject makeSnow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //������ ���߰� �����̱� �� ���� ������.
        //1.������ �����. true (EnemyMove�ȿ��� �ذ�)
    }
    public void Shoot()
    {
        //2.���� �����Ѵ�.(������ �κ��� Snow�� ����)
        GameObject pos =Instantiate(makeSnow);
        pos.transform.position = gameObject.transform.position;


        //3.������ �����̴� ������ ���� ������ �ʴ´�. False(���ߴ� �κ��� �Ѱ��� ������ ��� �Ǵºκ�)
    }
}
