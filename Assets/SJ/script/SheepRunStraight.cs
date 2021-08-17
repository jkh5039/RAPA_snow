using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepRunStraight : MonoBehaviour
{
    public float speed;
    float curruntime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curruntime = curruntime + Time.deltaTime;
        gameObject.transform.localPosition += transform.forward * speed * Time.deltaTime;
        if (curruntime > 4)
        {
            Destroy(gameObject);
        }
    }
}
