using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winchecktwo : MonoBehaviour
{
    public bool checktwo;

    public GameObject greenwintwo;


    public void Start()
    {

        checktwo = false;
        greenwintwo.SetActive(false);
    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            checktwo = true;
            greenwintwo.SetActive(true);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("player"))
        {
            checktwo = false;
            greenwintwo.SetActive(false);
        }
    }

}
