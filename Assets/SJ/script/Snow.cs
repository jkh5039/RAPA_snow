using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    //�����̰� ���ư��� �ӵ�
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += transform.right *speed* Time.deltaTime;
        gameObject.transform.localScale -= Vector3.one * 0.002f;
        if (gameObject.transform.localScale.x <0)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        //������ ü���� ��� �Ѵ�.(���� ���ڵ尡 �ʿ�)
    }

}
