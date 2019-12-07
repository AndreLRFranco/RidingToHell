using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TimerToMenu : MonoBehaviour
{
    public string levelToload;
    public float timer = 10f;
    private Text timerSeconds;

    void Start()
    {
        timerSeconds = GetComponent<Text>();


    }


    void Update()
    {
        timer -= Time.deltaTime;

        timerSeconds.text = "Time: " + timer.ToString("f2");


        if (timer <= 0)
        {
            Debug.Log("ACABOU O TEMPOW");
            SceneManager.LoadScene("Menu");
        }
    }
}
