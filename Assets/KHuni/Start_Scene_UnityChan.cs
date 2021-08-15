using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start_Scene_UnityChan : MonoBehaviour
{
    public float speed = 5.0f;
    public Animator animator;
    float currTime = 0.0f;
    float turnTIme = 3.0f;
    float turnTime2 = 6.0f;
    float turnTime3 = 9.0f;
    float turnTime4 = 12.0f;
    float[] turnTimes = { 3, 1, 2, 5 };
    int timeIdx = 0;

    public Transform[] points;
    int pointIdx = 0;

    Vector3 dir;

    // Start is called before the first frame update
    void Start()
    {
        animator.SetBool("Run", true);
        ChangeDir();
    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime; //시간흐른다
        if(currTime > turnTimes[timeIdx])
        {
            ChangeDir();
            timeIdx++;
            currTime = 0;
            if(timeIdx >= turnTimes.Length)
            {
                timeIdx = 0;
            }
        }

        
        //if (currTime>=turnTIme&& currTime <turnTime2)
        //{
        //    ChangeDir();
        //}
        
        //else if (currTime >= turnTime2 && currTime < turnTime3 ) //3초가지난다
        //{
        //    ChangeDir();
        //    //currTime = 0; //초기화한다
        //    //다시반대로뛰는거 어떻게함????? //무한루프
        //}
        //else if(currTime>=turnTime3 && currTime<turnTime4)
        //{
        //    ChangeDir();
        //}
        //else if (currTime > turnTime4)
        //{
        //    currTime = 0;
        //}

        transform.position += -transform.right * speed * Time.deltaTime;
    }

    void ChangeDir()
    {
        dir = points[pointIdx].position - transform.position;
        transform.right = -dir;
        pointIdx++;
        if(pointIdx >= points.Length)
        {
            pointIdx = 0;
        }
    }
}
