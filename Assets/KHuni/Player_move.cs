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

    bool isPlayerClick;

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
                isPlayerClick = true;
            }
        }
        if (Input.GetButtonUp("Fire1"))
        {
            isPlayerClick = false;
        }

        if (isPlayerClick)
        {
            //Ray발사!!

            if (Physics.Raycast(ray, out hitInfo, 1000, ~layer))
            {
                transform.position = hitInfo.point;
            }
        }
    }
}
