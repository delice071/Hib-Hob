using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    AudioSource audioSO;
    public AudioClip click;

    private void Start()
    {
        audioSO = GetComponent<AudioSource>();
    }

        public void playmove()
    {
        audioSO.PlayOneShot(click);
        SceneManager.LoadScene(1);
    }


    public void exitMenu()
    {
        audioSO.PlayOneShot(click);
        Application.Quit();

    }

    public void tryAgainn()
    {
        audioSO.PlayOneShot(click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void menuu()
    {
        audioSO.PlayOneShot(click);
        SceneManager.LoadScene(0);
    }
    public void NextGame()
    {
        audioSO.PlayOneShot(click);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
