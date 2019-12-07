using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    public class GameOverManager : MonoBehaviour
    {
        public PlayerHealth playerHealth;       // Reference to the player's health.
        //public float restartDelay = 5f;         // Time to restart level
        public string retryScene;
        public string nextScene;

        Animator anim;                          // Reference to the animator component.

    public float timer; //public float restartTimer;


    void Awake()
        {
            // Set up the reference.
            anim = GetComponent<Animator>();
            
            
        }

        void Update()
        {
            // If the player has run out of health...
            if (playerHealth.currentHealth <= 0)
            {

                anim.SetTrigger("GameOver");

               /* restartTimer += Time.deltaTime;
                 if (restartTimer >= restartDelay)
                 {
                SceneManager.LoadScene("Level00");
                  }*/

            }

            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                //Debug.Log("ACABOU O TEMPOW");
                anim.SetTrigger("WinAnim");
            
            }
    }


    public void Retry()
    {
        SceneManager.LoadScene(retryScene);
    }

    public void BackMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(nextScene);
    }
}