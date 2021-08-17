using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepRunStraight1 : MonoBehaviour
{
    public float speed;
    float curruntime;
    public float ro;
    public float roTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        curruntime = curruntime + Time.deltaTime;
        gameObject.transform.localPosition += transform.forward * speed * Time.deltaTime;
        if(curruntime<roTime)
        {
        gameObject.transform.rotation = Quaternion.AngleAxis(ro,Vector3.up)*transform.rotation;
        }
        if (curruntime > 8)
        {
            Destroy(gameObject);
        }
    }
}
