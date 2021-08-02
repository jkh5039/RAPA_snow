using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float speed = 0;
    float timer=3;
    //float timer = 0;을 해줘도 되지만 class는 디폴트 값이 0이기 때문에 생략 가능.
    Vector3 dirR;
    Vector3 dirF;
    float rand;
    GameObject taget;

    public EnemyFire enemyFire;

    bool isMove = true;
    //속성 붙이는것은 한번만 붙여준다. 속성을 가지고 있는 변수에 속성을 붙이게 되면 중복선언을 하게 되는것이기 떄문.
    // Start is called before the first frame update
    void Start()
    {
        
        dirR = Vector3.right;
        dirF = Vector3.forward;

    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltatime : 시간보정 += : 자기 자신을 한번 더 더해준다.
        //gameObject.transform.position = gameObject.transform.position 
        //클래스 안에 있는 속성을 변경 하려면 "."을 이용하고 새로 생성 할때는 변수를 사용 한다.
        timer += Time.deltaTime;
        //deltaTime이 float이기 때문에 소숫점으로 수치가 쌓인다. 내가 원하는 값에 다른방향으로 갈수있게 한다.
        if (timer >rand)
        {

            DirChange();
            //랜덤한 값을 뽑자
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
            //좌우로 움직이게 한다.
            gameObject.transform.position += dirR * Time.deltaTime * speed;
            //앞뒤로 움직이게 한다.
            gameObject.transform.position += dirF * Time.deltaTime * speed;
        }
    }
    void DirChange()
    {
        //랜덤한 값을 구하자(0, 1)
        int rand;

        rand = Random.Range(0, 2);
        //만약에 rand값이 0이면
        if(rand == 0)
        {
            //방향바꿔라
            dirR = -dirR;
        }

        rand = Random.Range(0, 2);
        //만약에 rand값이 0이면
        if (rand == 0)
        {
            //방향바꿔라
            dirF = -dirF;
        }


        ////일정시간후 좌우를 바뀌게 한다.
        //dirR = -dirR;
        //dirF = -dirF;
    }
}
