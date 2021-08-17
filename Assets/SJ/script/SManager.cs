using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SManager : MonoBehaviour
{
    public static SManager instance;
    int foxno=3;
    int playlerno=3;
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CountFoxDie()
    {
        foxno = foxno - 1;
        if(foxno == 0)
        {
            SceneManager.LoadScene("success");
        }
    }
    public void CountPlayerDie()
    {
        SceneManager.LoadScene("fail");
    }
}
