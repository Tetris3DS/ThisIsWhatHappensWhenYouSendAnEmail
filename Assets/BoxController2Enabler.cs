using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController2Enabler : MonoBehaviour
{
    public bool MagicLine = false;
    
   

        private void OnTriggerEnter2D(Collider2D col)
        {
        Debug.Log("Haha!");
            if (col.gameObject.tag == "WandRange")
            {
                this.GetComponent<BoxController2>().enabled = true;
            MagicLine = true;
            }
        }
    private void OnTriggerExit2D(Collider2D col)
    {
        Debug.Log("Lala!");
        if (col.gameObject.tag == "WandRange")
        {
            this.GetComponent<BoxController2>().enabled = false;
            MagicLine = false;
        }
    }

    private void Update()
    {

    }

    private void MagicLineInitial()
    {

    }
    //void Start()
    //{

    //        this.GetComponent<BoxController2>().enabled = true;

    //}
}
