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
            DontDestroyOnLoad(gameObject); //scene�� ��ȯ�ǵ� �ı��ǰ���� ������ ����
        }
        else
        {
            Destroy(gameObject);
        }
    }
    //����� ���� (������)
    public enum BGM_SOUND_TYPE
    {
        BGM_START = 0,
        BGM_INGAME = 1
    }

    public AudioSource asBgm;
    public AudioClip[] bgmAudios;


    //BGM Play
    public void PlayBGM(BGM_SOUND_TYPE type) //����� AUDIOSOUCE�� 2�� ������ �־���Ѵ�
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
