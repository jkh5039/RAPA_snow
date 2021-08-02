using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snow : MonoBehaviour
{
    //´«µ¢ÀÌ°¡ ³¯¾Æ°¡´Â ¼Óµµ
    public float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += transform.forward *speed* Time.deltaTime;
    }
}
