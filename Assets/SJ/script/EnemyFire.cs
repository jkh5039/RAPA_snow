using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFire : MonoBehaviour
{

    //총구
    public GameObject makeSnow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //적군이 멈추고 움직이기 전 눈을 던진다.
        //1.적군이 멈춘다. true (EnemyMove안에서 해결)
    }
    public void Shoot()
    {
        //2.눈을 생성한다.(던지는 부분은 Snow에 넣음)
        GameObject pos =Instantiate(makeSnow);
        pos.transform.position = gameObject.transform.position;


        //3.적군이 움직이는 동안은 눈을 던지지 않는다. False(멈추는 부분이 한개기 떄문에 없어도 되는부분)
    }
}
