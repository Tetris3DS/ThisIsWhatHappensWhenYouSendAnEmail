using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStandOn : MonoBehaviour
{
    public GameObject noKeyGate;
    private Animation anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "button")
        {
            //Destroy(GameObject.FindWithTag("buttonGate"));
            anim = noKeyGate.GetComponent<Animation>();
            anim.Play("DoorOpening");
        }
    }
}
