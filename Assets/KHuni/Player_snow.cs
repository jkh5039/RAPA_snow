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
        if (Input.GetButtonDown("Fire1")==true) //���ʸ��콺 ������
        {

            //���콺�� ���������� ���� ���ӽð��� ����
            while (Input.GetButtonUp("Fire1")==true)
            {
                ClickTime = Time.deltaTime;
            }
            //ClickTime = Time.fixedDeltaTime; ??????

            //Ŭ����ư ���� �ð��� ���� clicktime���� �����´�
            //���� Ŭ���ð��� x�� �ʰ��ȴٸ� x�ʷ� ó���Ѵ�
            if (ClickTime > 3)
            {
                ClickTime = 3;
            }

            GameObject snow = Instantiate(snowFactory); //�����̸� ������.
            snow.transform.position = snowPos.transform.position; //���� �����̸� �ȿ��� �д�
            // eg(�⺻���Ÿ�Y+ ����ġw * �ð�)
            float DestroyTime = 1+ 0.6f*ClickTime;
            //���� �Ŀ� �����̰� destroy���ȴ� (�����ð��� ���������� �Ÿ��� �ִ�)
            Destroy(snow, DestroyTime);



            //GameObject snow = Instantiate(snowFactory); //�����̸� ������.
            //snow.transform.position = snowPos.transform.position; //���� �����̸� �ȿ��� �д�
        }
    }
}
