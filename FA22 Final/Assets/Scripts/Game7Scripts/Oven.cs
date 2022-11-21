using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oven : MonoBehaviour
{

    public TimerAnimator timer;

    public Animator ovenanim;

    public bool isReady = false;

    public bool Game7Fail = true;

    public bool Game7Fucked = false;
    
    void Start()
    {
        ovenanim = GetComponent<Animator>();
        Invoke("BecomeReady", 6f);
        Invoke("NoLongerReady", 7.5f);
    }

    void BecomeReady()
    {
        isReady = true;
        timer.TimerTime();
        Debug.Log("Now!");
    }

    void NoLongerReady()
    {
        isReady = false;
        Debug.Log("Stop!");
    }

    private void OnMouseDown()
    {
        ovenanim.Play("OpenOven");

        if (isReady == true)
        {
            Debug.Log("Got it!");
            Game7Fail = false;
        }

        if (isReady == false)
        {
            Debug.Log("You fucked up!");
            Game7Fucked = true;
        }
    }
}