using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultM : MonoBehaviour
{
    public GameObject Title;
    public GameObject StartButton;
    // Start is called before the first frame update
    float currTime;
    
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        currTime += Time.deltaTime;
        if (currTime > 2.5f)
        {
            //itween
            iTween.ScaleTo(StartButton, iTween.Hash(
                "x", 1,
                "y", 2,
                "z", 1,
                "time", 1,
                "easetype", iTween.EaseType.easeInOutBack

                ));
            iTween.ScaleTo(StartButton, iTween.Hash(
                "x", 1.2,
                "y", 2.4,
                "z", 1.2,
                "time", 1,
                "delay", 0.5f,
                "easetype", iTween.EaseType.easeInOutBack
                ));
            currTime = 0;
        }
    }
    public void OnclickStart()
    {
        //GameScene으로 전환한다
        SceneManager.LoadScene("SSJ_Scene");
    }
}
