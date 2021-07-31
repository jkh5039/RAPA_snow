using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 0;
    float timer=3;
    //float timer = 0;�� ���൵ ������ class�� ����Ʈ ���� 0�̱� ������ ���� ����.
    Vector3 dirR;
    Vector3 dirF;
    float rand;
    GameObject taget;

    public EnemyFire enemyFire;

    bool isMove = true;
    //�Ӽ� ���̴°��� �ѹ��� �ٿ��ش�. �Ӽ��� ������ �ִ� ������ �Ӽ��� ���̰� �Ǹ� �ߺ������� �ϰ� �Ǵ°��̱� ����.
    // Start is called before the first frame update
    void Start()
    {
        
        dirR = Vector3.right;
        dirF = Vector3.forward;

    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltatime : �ð����� += : �ڱ� �ڽ��� �ѹ� �� �����ش�.
        //gameObject.transform.position = gameObject.transform.position 
        //Ŭ���� �ȿ� �ִ� �Ӽ��� ���� �Ϸ��� "."�� �̿��ϰ� ���� ���� �Ҷ��� ������ ��� �Ѵ�.
        timer += Time.deltaTime;
        //deltaTime�� float�̱� ������ �Ҽ������� ��ġ�� ���δ�. ���� ���ϴ� ���� �ٸ��������� �����ְ� �Ѵ�.
        if (timer >rand)
        {

            DirChange();
            //������ ���� ����
            rand = Random.Range(1, 5);
            //dirR.Normalize();
            //dirF.Normalize();

            timer = 0;
            isMove = !isMove;
            if (isMove)
            {
                enemyFire.Shoot();
            }
        }

        if(isMove)
        {
            //�¿�� �����̰� �Ѵ�.
            gameObject.transform.position += dirR * Time.deltaTime * speed;
            //�յڷ� �����̰� �Ѵ�.
            gameObject.transform.position += dirF * Time.deltaTime * speed;
        }
    }
    void DirChange()
    {
        //������ ���� ������(0, 1)
        int rand;

        rand = Random.Range(0, 2);
        //���࿡ rand���� 0�̸�
        if(rand == 0)
        {
            //����ٲ��
            dirR = -dirR;
        }

        rand = Random.Range(0, 2);
        //���࿡ rand���� 0�̸�
        if (rand == 0)
        {
            //����ٲ��
            dirF = -dirF;
        }


        ////�����ð��� �¿츦 �ٲ�� �Ѵ�.
        //dirR = -dirR;
        //dirF = -dirF;
    }
}
