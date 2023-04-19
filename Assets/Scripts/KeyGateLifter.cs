using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGateLifter : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "keyhole")
        {
            Destroy(GameObject.FindWithTag("keyGate"));
        }
    }
}
