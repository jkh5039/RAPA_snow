using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_snow : MonoBehaviour
{
    // 눈덩이 공장
    public GameObject snowFactory;
    public GameObject snowPos;
    float ClickTime;
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
            
            //마우스를 뗴기전까지 누른 지속시간을 잰다111
            while (Input.GetButtonUp("Fire1") != true)
            {
                float ClickTime = Time.deltaTime;
            }
            //ClickTime = Time.fixedDeltaTime; ??????

            //클릭버튼 누른 시간을 변수 clicktime으로 가져온다
            //만약 클릭시간이 x초 초과된다면 x초로 처리한다 
            if (ClickTime > 3)
            {
                ClickTime = 3;
            }

            GameObject snow = Instantiate(snowFactory); //눈덩이를 만든다.
            snow.transform.position = snowPos.transform.position; //만든 눈덩이를 팔에다 둔다
            // eg(기본사거리Y+ 가중치w * 시간)
            float DestroyTime = 1+ 0.6f*ClickTime;
            //몇초 후에 눈덩이가 destroy가된다 (누른시간이 길면길수록 거리가 멀다)
            Destroy(snow, DestroyTime);
            
            

            //GameObject snow = Instantiate(snowFactory); //눈덩이를 만든다.
            //snow.transform.position = snowPos.transform.position; //만든 눈덩이를 팔에다 둔다
        }
    }
}
