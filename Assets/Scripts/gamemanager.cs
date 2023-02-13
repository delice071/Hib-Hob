using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamemanager : MonoBehaviour
{
    public GameObject checkone, checktwo, win, nextgame, menuu;
    AudioSource audioSO;
    public AudioClip succes;


    public void Start()
    {
        audioSO= GetComponent<AudioSource>();
        win.SetActive(false);
        nextgame.SetActive(false);
        menuu.SetActive(false);
    }
    public void FixedUpdate()
    {
        if(checkone.GetComponent<wincheckone>().checkone == true & checktwo.GetComponent<winchecktwo>().checktwo == true)
        {
            audioSO.PlayOneShot(succes);
            Invoke(nameof(winner), 0.5f);
        }
        
    }


    private void winner()
    {
       
        Time.timeScale = 0;
        win.SetActive(true);
        nextgame.SetActive(true);
        menuu.SetActive(true);
    }
}
