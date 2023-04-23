using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lvl3Door1 : MonoBehaviour
{
    public GameObject noKeyGate;
    private Animation anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
            //Destroy(GameObject.FindWithTag("buttonGate"));
            anim = noKeyGate.GetComponent<Animation>();
            anim.Play("Lvl3Door1");
        
    }
}
