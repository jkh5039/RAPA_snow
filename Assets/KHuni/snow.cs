using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snow : MonoBehaviour
{
    //������ �ӵ�
    public float speed = 6.0f;
    //������ �����Ÿ� 
    public float distance = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        //������ ���ӽð�
        float LiveTime = Time.deltaTime * distance;
    }

    // Update is called once per frame
    void Update()
    {
        //�Ѿ� ���󰡴¹���, ȸ���ɾ����� �� �������ΰ��� (�� ����)
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
