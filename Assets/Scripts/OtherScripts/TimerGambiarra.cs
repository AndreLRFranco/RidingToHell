using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TimerGambiarra : MonoBehaviour
{

    public float timer;
    Animator anim;


    void Start()
    {

        anim = GetComponent<Animator>();
    }


    void Update()
    {
        timer -= Time.deltaTime;


        if (timer <= 0)
        {
            //Debug.Log("ACABOU O TEMPOW");
            anim.SetTrigger("WinAnim");
        }
    }

}
