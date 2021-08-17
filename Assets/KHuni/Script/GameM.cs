using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameM : MonoBehaviour
{
    

    public enum GAME_STATE
    {
        Ready,
        Start,
        Playing
    }
    public GAME_STATE state;
    float currtime = 0; //현재시간
    public Text ReadyUI;
    public Player_move player;

    public static GameM instance;
    //Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.PlayBGM(SoundManager.BGM_SOUND_TYPE.BGM_INGAME);
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        currtime += Time.deltaTime;
        if (state== GAME_STATE.Ready)
        {
            if (currtime > 1)
            {
                state = GAME_STATE.Start;
                ReadyUI.text = "Start!";
                currtime = 0;
            }
        }

        else if (state== GAME_STATE.Start)
        {
            if (currtime > 0.5f)
            {
                state = GAME_STATE.Playing;
                ReadyUI.gameObject.SetActive(false);
            }
        }
    }
    public bool IsPlaying()
    {
        if (state== GAME_STATE.Playing)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
