using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading01 : MonoBehaviour
{
    public float restartTimer;
    public float restartDelay;
    public string sceneName;
    void Update()
    {

            restartTimer += Time.deltaTime;
            if (restartTimer >= restartDelay)
            {
                if (Input.anyKey)
             {
                    Debug.Log("GAMEGAMEGAME");
                    SceneManager.LoadScene(sceneName);
                }
            }

    }
}
