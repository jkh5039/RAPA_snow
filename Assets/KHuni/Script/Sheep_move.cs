using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sheep_move : MonoBehaviour
{
    public float speed = 6.0f;
    float currTime=0;
    float moveTime = 0;
    //float turnTIme = 3.0f;
    //float turnTime2 = 6.0f;
    //float turnTime3 = 9.0f;
    //float turnTime4 = 12.0f;

    Vector3 dir;
    // Start is called before the first frame update
    GameObject player;
    GameObject followPos;
    void Start()
    {
        player = GameObject.Find("Player");
        followPos = GameObject.Find("followPos");
    }

    // Update is called once per frame
    void Update()
    {
        

        #region sheep move
        //moveTime += Time.deltaTime; //�ð��帥��

        //if (moveTime < turnTIme)
        //{
        //    transform.Translate(Vector3.forward * speed * Time.deltaTime); //�·� �ڴ�
        //}

        //else if (moveTime >= turnTIme && moveTime < turnTime2)
        //{


        //    transform.Translate(Vector3.right * speed * Time.deltaTime);
        //}

        //else if (moveTime >= turnTime2 && moveTime < turnTime3) //3�ʰ�������
        //{
        //    transform.Translate(Vector3.back * speed * Time.deltaTime); //��� �ڴ�
        //    //currTime = 0; //�ʱ�ȭ�Ѵ�
        //    //�ٽùݴ�ζٴ°� �����????? //���ѷ���
        //}
        //else if (moveTime >= turnTime3 && moveTime < turnTime4)
        //{
        //    transform.Translate(Vector3.left * speed * Time.deltaTime);
        //}
        //else if (moveTime > turnTime4)
        //{
        //    moveTime = 0;
        //}
        #endregion

        

        //transform.LookAt(player.transform);
        //iTween.MoveTo(gameObject, player.transform.position, 4f);
        dir = player.transform.position - followPos.transform.position;
        dir.Normalize();
        transform.LookAt(followPos.transform);
        //transform.position = followPos.transform.position;
        //transform.position += dir * speed * Time.deltaTime;
        transform.position = followPos.transform.position;



    }

    


}
