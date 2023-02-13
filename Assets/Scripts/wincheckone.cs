using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class wincheckone : MonoBehaviour
{
    public bool checkone;

    public GameObject greenwin;


    public void Start()
    {

        checkone= false;
        greenwin.SetActive(false);
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            checkone= true;
            greenwin.SetActive(true);
            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            checkone = false;
            greenwin.SetActive(false);
        }
    }

}
