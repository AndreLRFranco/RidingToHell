using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    Animator anim;


    //Camera cam;
    
    public float restartTimer;
    public float restartDelay = 5f;
    public bool playGameOn = false;

    private void Awake()
    {
        anim = GetComponent<Animator>();

        //cam = GetComponent<Camera>();



    }
    private void Update()
    {
        if (playGameOn == true)
        {
            restartTimer += Time.deltaTime;
            if (restartTimer >= restartDelay)
            {
                Debug.Log("GAMEGAMEGAME");
                SceneManager.LoadScene("Loading1");
                
            }
        }
    }

    public void PlayGame()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //Proxima cena na listinha da build

        Debug.Log("Aguardando...");
        anim.SetTrigger("screenFade");
        playGameOn = true;
        

    }
    public void HowToPlay()
    {
        anim.SetTrigger("MenuHowto");

    }
    public void HowToPlayBackToMenu()
    {
        anim.SetTrigger("HowtoToMenu");
    }

    public void Settings()
    {
        anim.SetTrigger("MenuSetting");
    }

    public void SettingsBackToMenu()
    {
        anim.SetTrigger("SettingMenu");
    }

    public void Credits()
    {
        anim.SetTrigger("MenuToCredit");

    }
    public void CreditsBackToMenu()
    {
        anim.SetTrigger("CreditToMenu");
    }
    public void Quit()
    {
        //SceneManager.LoadScene("SeeYouHell");
        Application.Quit();
        Debug.Log("QUIT");
    }


}
