using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_snow : MonoBehaviour
{
    // ������ ����
    public GameObject snowFactory;
    public GameObject snowPos;
    // ���ư��� ����, fix�� �������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1")==true) //���ʸ��콺 ������
        {
            GameObject snow = Instantiate(snowFactory); //�Ѿ��������.
            snow.transform.position = snowPos.transform.position; //���� �Ѿ��� �ȿ��� �д�
        }
    }
}
