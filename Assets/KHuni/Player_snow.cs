using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_snow : MonoBehaviour
{
    // ������ ����
    public GameObject snowFactory;
    public GameObject snowPos;
    float ClickTime = 0f;
    // ���ư��� ����, fix�� ��������
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")==true) //발사버튼클릭
        {

            
            //���콺�� ��������� ���� ���ӽð��� ���111
            while (Input.GetButtonUp("Fire1") != true)
            {
                float ClickTime = Time.deltaTime;

            //클릭시간에비례한 사거리증가
            while (Input.GetButtonUp("Fire1") == true)
            {
                ClickTime = Time.deltaTime;
 
            }
            ////ClickTime = Time.fixedDeltaTime; ??????

            //클릭시간이 3초보다 길면 3초로 처리
            if (ClickTime > 3)
            {
                ClickTime = 3;
            }

            GameObject snow = Instantiate(snowFactory); //공장에서 눈덩이만듬
            snow.transform.position = snowPos.transform.position; //���� �����̸� �ȿ��� �д�

            ClickTime = Time.deltaTime;
            //일정시간 지난후 snow를 파괴한다
            Destroy(snow, ClickTime);
            ClickTime = 0;



            //GameObject snow = Instantiate(snowFactory); //�����̸� ������.
            //snow.transform.position = snowPos.transform.position; //���� �����̸� �ȿ��� �д�
        }
    }
}
