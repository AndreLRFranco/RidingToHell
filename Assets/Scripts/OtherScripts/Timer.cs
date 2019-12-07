using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    private Text timerSeconds;

    Animator anim;

    void Start()
    {
        timerSeconds = GetComponent<Text>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        timer -= Time.deltaTime;

        timerSeconds.text = "Time: " + timer.ToString("f2");

        if (timer <= 0)
        {
            timer = 0; 
        }    
    }
}
