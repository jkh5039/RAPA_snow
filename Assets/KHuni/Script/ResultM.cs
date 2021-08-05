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
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnclickStart()
    {
        //GameScene으로 전환한다
        SceneManager.LoadScene("snowballing_game");
    }
}
