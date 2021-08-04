using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    //Camera  게임오브젝트
    public GameObject camObj;
    //Camera 컴포넌트
    Camera cam;
    //충돌하고 싶지않은 Layer
    public LayerMask layer;
    public GameObject snowFactory; 
    public GameObject snowPos;

    public bool isPlayerClick;

    // Start is called before the first frame update
    void Start()
    {
        cam = camObj.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //화면 마우스 좌표에서 발사되는 Ray를 만든다.
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if (Input.GetButtonDown("Fire1"))
        {
            if (Physics.Raycast(ray, out hitInfo, 1000, layer))
            {
                //isPlayerClick = true;
                Player_move pm = hitInfo.transform.GetComponent<Player_move>();
                pm.isPlayerClick = true;
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            //만약에 isPlayerClick 참이라면
            if (isPlayerClick == true)
            {
                float ClickTime = Time.deltaTime;
                //총알발사
                GameObject snow = Instantiate(snowFactory);
                snow.transform.position = snowPos.transform.position;
                Destroy(snow, 10);
                ClickTime = 0;
            }
            
            isPlayerClick = false;
        }

        if (isPlayerClick)
        {
            //Ray발사!!

            if (Physics.Raycast(ray, out hitInfo, 1000, ~layer))
            {
                Vector3 vec = new Vector3(hitInfo.point.x, hitInfo.point.y + 1.7f, hitInfo.point.z);
                transform.position = vec;
            }
        }
    }
}
