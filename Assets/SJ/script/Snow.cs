using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    //눈덩이가 날아가는 속도
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
        //상대방의 체력을 닳게 한다.(상대방 피코드가 필요)
    }

}
