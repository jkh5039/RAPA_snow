using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_snow : MonoBehaviour
{
    // 눈덩이 공장
    public GameObject snowFactory;
    public GameObject snowPos;
    // 날아가는 방향, fix라 상관없음
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")==true) //왼쪽마우스 누르면
        {
            GameObject snow = Instantiate(snowFactory); //총알을만든다.
            snow.transform.position = snowPos.transform.position; //만든 총알을 팔에다 둔다
        }
    }
}
