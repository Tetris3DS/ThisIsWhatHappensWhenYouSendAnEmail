using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MrTestoTriangleOnTrigger : MonoBehaviour
{
private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.gameObject.name);
        if (collision.gameObject.tag == "WandRange")
        {
            this.GetComponent<BoxController2>().enabled = true;
        }
    }
}
