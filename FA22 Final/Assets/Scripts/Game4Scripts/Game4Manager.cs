using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game4Manager : MonoBehaviour
{

    public CalamaxController lich;
    
    public Game4Lever Lever;
    [SerializeField] GameObject failAnim;
    [SerializeField] GameObject successAnim;
    
    [SerializeField] AudioSource successChime;
    [SerializeField] AudioSource failChime;
    
    [SerializeField] AudioSource successTune;
    [SerializeField] AudioSource failTune;
    
    private void Start()
    {
        Lever = GameObject.Find("Game4Lever").GetComponent<Game4Lever>();
    }
    
    public void Game4Results()
    {
        if (Lever.Game4Fail == false)
        {
            Debug.Log("You Passed Game 2!");
            successAnim.SetActive(true);
            successChime.Play();
            successTune.Play();
            lich.LichSip();
            Scoring.totalScore++;
        }
        if (Lever.Game4Fail == true)
        {
            Debug.Log("You Failed Game 2!");
            failAnim.SetActive(true);
            failChime.Play();
            failTune.Play();
            lich.LichFail();
        }
    }
    
}
