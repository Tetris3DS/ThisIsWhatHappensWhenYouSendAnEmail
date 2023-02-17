using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelectionArrowMovement : MonoBehaviour
{


 function OnTriggerEnter(info : Collider)
 {
      if(info.gameObject.tag == "WandRange")
     {
           if (Input.GetKey(KeyCode.RightArrow))
     {
         transform.position += Vector3.right * speed * Time.deltaTime;
     }
 }
 }
}
