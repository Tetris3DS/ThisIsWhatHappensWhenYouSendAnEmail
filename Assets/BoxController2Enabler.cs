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
        if (MagicLine == true)
        {

        }

    }

    private void MagicLineInitial()
    {
        var go = new GameObject();
        var lr = go.AddComponent<LineRenderer>();

        var player = GameObject.Find("Player");
        var magic = GameObject.Find("SelectableObject");

        //lr.material.SetTexture("LightningLine");
        lr.SetPosition(0, player.transform.position);
        lr.SetPosition(1, magic.transform.position);
    }
    //void Start()
    //{

    //        this.GetComponent<BoxController2>().enabled = true;

    //}
}
