using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); //scene이 전환되도 파괴되고싶지 않을때 쓴다
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //배경음 종류 (열거형)
    public enum BGM_SOUND_TYPE
    {
        BGM_START = 0,
        BGM_INGAME = 1
    }

    public AudioSource asBgm;
    public AudioClip[] bgmAudios;


    //BGM Play
    public void PlayBGM(BGM_SOUND_TYPE type) //브금은 AUDIOSOUCE를 2개 가지고 있어야한다
    {
        asBgm.clip = bgmAudios[(int)type];
        asBgm.Play();
    }

    public void StopBGM()
    {
        asBgm.Stop();
    }

    // Start is called before the first frame update
    void Start()
    {
        //asBgm = GetComponentInChildren<AudioSource>();
        PlayBGM(BGM_SOUND_TYPE.BGM_START);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
