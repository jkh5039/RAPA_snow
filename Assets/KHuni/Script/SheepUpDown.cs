using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepUpDown : MonoBehaviour
{
    public float currTime = 0f;
    public float speed = 5.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        UpDownSheep();
    }
    void UpDownSheep()
    {
        currTime += Time.deltaTime;
        if (currTime < .3)
        {
            gameObject.transform.localPosition+=(Vector3.up * speed * Time.deltaTime);
        }
        else if (currTime < .6)
        {
            gameObject.transform.localPosition+=(Vector3.down * speed * Time.deltaTime);
        }
        else
        {
            currTime = 0;
        }
    }
}
