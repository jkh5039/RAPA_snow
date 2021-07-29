using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class snow : MonoBehaviour
{
    //눈덩이 속도
    public float speed = 6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //총알 날라가는방향, 회전걸었더니 그 방향으로간다 (나 기준)
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }
}
