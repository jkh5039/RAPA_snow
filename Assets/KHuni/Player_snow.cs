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

            //만약 일정시간동안누르면
            
            //그 시간을 가져온다
            //클릭버튼 누른 시간을 가져온다
            //만약 x초 이상누른다면 x초로 처리한다
            //eg(1+ 가중치w * 시간)
            //몇초 후에 눈덩이가 destroy가된다
            
            GameObject snow = Instantiate(snowFactory); //눈덩이를 만든다.
            snow.transform.position = snowPos.transform.position; //만든 눈덩이를 팔에다 둔다
        }
    }
}
