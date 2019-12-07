using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MaisUmTimerSafado : MonoBehaviour
{

    public float timer = 4;


    void Update()
    {
        timer -= Time.deltaTime;


        if (timer <= 0)
        {
            Application.Quit();
            Debug.Log("Fechou");
        }
    }
}
