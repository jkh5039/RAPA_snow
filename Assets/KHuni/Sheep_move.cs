using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep_move : MonoBehaviour
{
    public float speed = 3.0f;
    float currTime=0;
    float moveTime = 0;
    float turnTIme = 3.0f;
    float turnTime2 = 6.0f;
    float turnTime3 = 9.0f;
    float turnTime4 = 12.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpDownSheep();

        moveTime += Time.deltaTime; //시간흐른다

        if (moveTime < turnTIme)
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime); //좌로 뛴다
        }

        else if (moveTime >= turnTIme && moveTime < turnTime2)
        {


            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        else if (moveTime >= turnTime2 && moveTime < turnTime3) //3초가지난다
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime); //우로 뛴다
            //currTime = 0; //초기화한다
            //다시반대로뛰는거 어떻게함????? //무한루프
        }
        else if (moveTime >= turnTime3 && moveTime < turnTime4)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        else if (moveTime > turnTime4)
        {
            moveTime = 0;
        }
    }

    void UpDownSheep()
    {
        currTime += Time.deltaTime;
        if (currTime < 0.5)
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        else if (currTime < 1)
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
        else
        {
            currTime = 0;
        }
    }


}
