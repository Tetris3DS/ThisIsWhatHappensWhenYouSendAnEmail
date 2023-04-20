using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGateLifter : MonoBehaviour
{
    public GameObject KeyGate;
    private Animation anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "keyhole")
        {
            //Destroy(GameObject.FindWithTag("keyGate"));
            anim = KeyGate.GetComponent<Animation>();
            anim.Play("KeyDoorOpening");
            KeyGate.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
