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

        SoundManager.instance.PlayBGM(SoundManager.BGM_SOUND_TYPE.BGM_START);
    }

    // Update is called once per frame
    void Update()
    {
        //SoundManager.instance.PlayBGM(SoundManager.BGM_SOUND_TYPE.BGM_START);
        //SoundManager.instance.PlayBGM(SoundManager.BGM_SOUND_TYPE.BGM_INGAME);
    }
    public void OnclickStart()
    {
        //GameScene으로 전환한다
        SceneManager.LoadScene("snebn");
    }
}
