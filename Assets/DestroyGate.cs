using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGate : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "gate")
        {
            Destroy(GameObject.FindWithTag("gate"));
        }
    }
}
