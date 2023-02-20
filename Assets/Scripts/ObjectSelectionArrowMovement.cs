using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelectionArrowMovement : MonoBehaviour
{
    public float speed = 10f;

    public void OnTriggerEnter(Collider info)
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
