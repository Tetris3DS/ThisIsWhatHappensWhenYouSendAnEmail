using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyGateLifterLvl2Num1 : MonoBehaviour
{
    public GameObject KeyGate;
    private Animation anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "keyhole1")
        {
            //Destroy(GameObject.FindWithTag("keyGate"));
            anim = KeyGate.GetComponent<Animation>();
            anim.Play("KeyDoorLvl2Num1");
            KeyGate.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
