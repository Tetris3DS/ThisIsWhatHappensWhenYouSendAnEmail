using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonStandOn1 : MonoBehaviour
{
    public GameObject noKeyGate;
    private Animation anim;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        
            //Destroy(GameObject.FindWithTag("buttonGate"));
            anim = noKeyGate.GetComponent<Animation>();
            anim.Play("KeyDoorLvl2Num3");
        
    }
}
