using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    float currenttime = 2;
    public float speed = 0;
    float timer = 3;
    //float timer = 0;�� ���൵ ������ class�� ����Ʈ ���� 0�̱� ������ ���� ����.
    Vector3 dirR;
    Vector3 dirF;
    float rand;
    GameObject taget;

    public EnemyFire enemyFire;

    public bool moveStop;
    bool isMove = true;
    bool isHit = false;
    public Animator ani;
    int hit = 3;

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
        //deltaTime�� float�̱� ������ �Ҽ������� ��ġ�� ���δ�. ���� ���ϴ� ���� �ٸ��������� �����ְ� �Ѵ�
        //
        if (isHit == false)
        {
            if (timer > rand)
            {

                DirChange();
                //������ ���� ����
                rand = Random.Range(1, 5);
                //dirR.Normalize();
                //dirF.Normalize();

                timer = 0;
                isMove = !isMove;
                //���࿡ Ismove�� �����̶��
                if (isMove == false)
                {
                    //�ִϸ��̼� Idle�� ����
                    ani.SetTrigger("idle");

                }
                //���࿡ Ismove�� ���̶��
                //�ִϸ��̼��� atteck���� ����
                if (isMove)
                {
                    enemyFire.Shoot();
                    ani.SetTrigger("atteck");

                }
            }

            if (isMove && moveStop)
            {
                //�¿�� �����̰� �Ѵ�.
                gameObject.transform.position += dirR * Time.deltaTime * speed;
                //�յڷ� �����̰� �Ѵ�.
                gameObject.transform.position += dirF * Time.deltaTime * speed;
            }
        }

        if(isHit == true)
        {
            if(timer > 2)
            {
                timer = 0;
                isHit = false;
                isMove = false;
                ani.SetTrigger("idle");
            }
        }
            if (transform.position.z < -36f || transform.position.z > -9.7f)
            {
                dirF = -dirF;
            }
            if (transform.position.x < -18f || transform.position.x > 5f)
            {
                dirR = -dirR;
            }


        //if (Input.GetKeyDown(KeyCode.Alpha0))
        //{
        //    isHit = true;
        //    timer = 0;
        //    ani.SetTrigger("Falling");
        //}
    }
    void DirChange()
    {
        //������ ���� ������(0, 1)
        int rand;

        rand = Random.Range(0, 2);
        //���࿡ rand���� 0�̸�
        if (rand == 0)
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
    }
    private void OnTriggerEnter(Collider other)
    {
        hit = hit-1;
        if (hit == 0)
        {
            isHit = true;
            ani.SetTrigger("die");
        }
        isHit = true;
        timer = 0;
        ani.SetTrigger("Falling");
        //if (currenttime > Time.deltaTime)
        //{
        //    //�������� �ִϸ��̼��� ����ǰ� �������� �����.
        //    isMove = false;
        //    //���ʹ��� �������� �����.
        //
        
    }
}
