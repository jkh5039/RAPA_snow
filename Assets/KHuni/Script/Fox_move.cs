using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox_move : MonoBehaviour
{
    Vector3 dir;
    GameObject Player;
    GameObject followPos;
    GameObject followPos2;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.Find("Player");
        followPos = GameObject.Find("followPos");
        followPos2 = GameObject.Find("followPos2");
        //animator.SetBool("Run", true);
    }

    // Update is called once per frame
    void Update()
    {
        dir = Player.transform.position - followPos2.transform.position;
        dir.Normalize();
        transform.LookAt(followPos.transform);
        //transform.position = followPos.transform.position;
        //transform.position += dir * speed * Time.deltaTime;
        transform.position = followPos2.transform.position;
    }
}
