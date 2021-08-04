using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    //Camera  ���ӿ�����Ʈ
    public GameObject camObj;
    //Camera ������Ʈ
    Camera cam;
    //�浹�ϰ� �������� Layer
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
        //ȭ�� ���콺 ��ǥ���� �߻�Ǵ� Ray�� �����.
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
            //���࿡ isPlayerClick ���̶��
            if (isPlayerClick == true)
            {
                float ClickTime = Time.deltaTime;
                //�Ѿ˹߻�
                GameObject snow = Instantiate(snowFactory);
                snow.transform.position = snowPos.transform.position;
                Destroy(snow, 10);
                ClickTime = 0;
            }
            
            isPlayerClick = false;
        }

        if (isPlayerClick)
        {
            //Ray�߻�!!

            if (Physics.Raycast(ray, out hitInfo, 1000, ~layer))
            {
                Vector3 vec = new Vector3(hitInfo.point.x, hitInfo.point.y + 1.7f, hitInfo.point.z);
                transform.position = vec;
            }
        }
    }
}
