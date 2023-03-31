using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController2Enabler : MonoBehaviour
{
        private void OnTriggerEnter2D(Collider2D col)
        {
        Debug.Log("Haha!");
            if (col.gameObject.tag == "WandRange")
            {
                this.GetComponent<BoxController2>().enabled = true;
            }
        }
    //void Start()
    //{
       
    //        this.GetComponent<BoxController2>().enabled = true;
      
    //}
}
