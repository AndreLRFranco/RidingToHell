using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{


    public float restartTimer;
    public float restartDelay;
    void Update()
    {

        restartTimer += Time.deltaTime;
        if (restartTimer >= restartDelay)
        {
                Debug.Log("GAMEGAMEGAME");
                SceneManager.LoadScene("Menu");

        }

    }

}
