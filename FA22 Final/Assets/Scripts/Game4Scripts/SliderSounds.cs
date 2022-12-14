using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SliderSounds : MonoBehaviour
{

    public CalamaxController lich;

    public Slider slider;
    
    [SerializeField] AudioSource levergrab;
    [SerializeField] AudioSource leverhold;
    [SerializeField] AudioSource leverrelease;

    void OnMouseDown()
    {
        levergrab.Play();
        leverhold.Play();
        lich.Lich3Grab();
        Debug.Log("BLAHHH");
    }

    void OnMouseUp()
    {
        leverhold.Stop();
        leverrelease.Play();
        lich.Lich3Def();
        Debug.Log("FUCKK");
    }

    private float newSlider;
    
    void Update()
    {
        newSlider = (-slider.value / 5);
        gameObject.transform.position = new Vector3(0f, newSlider, 0f);
    }
}
