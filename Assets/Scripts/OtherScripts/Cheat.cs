using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cheat : MonoBehaviour
{
    public bool cheat = false;
    void Update()
    {
        if (Input.GetKey("z") && Input.GetKey("p"))
        {
            cheat = true;
        }

            // Go to Level 1
            if (Input.GetKeyDown("1") && cheat == true)
            {
                SceneManager.LoadScene("Loading1");
            }

            // Go to Level 2
            if (Input.GetKeyDown("2") && cheat == true)
            {
                SceneManager.LoadScene("Loading2");
            }

            // Go to level 3
            if (Input.GetKeyDown("3") && cheat == true)
            {
                SceneManager.LoadScene("Loading3");
            }

            // Go to Final
            if (Input.GetKeyDown("4") && cheat == true)
            {
                SceneManager.LoadScene("Final");
            }

            // Go to Menu
            if (Input.GetKeyDown("5") && cheat == true)
            {
                SceneManager.LoadScene("Menu");
            }

    }
}
