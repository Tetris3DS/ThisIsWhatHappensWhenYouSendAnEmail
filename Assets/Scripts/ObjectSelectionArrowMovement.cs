using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;


public class ObjectSelectionArrowMovement : MonoBehaviour
{
    public float speed = 10f;
 //  public Rigidbody2D m_Rigidbody;
   // float m_Speed;

    void Start()
    {
   // m_Speed = 10f;
   // m_Rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnTriggerEnter2D(Collider2D collider)
    {
        
         if(collider.gameObject.tag == "WandRange")
         {
              if (Input.GetKey(KeyCode.RightArrow))
              {
                   transform.position += Vector3.right * speed * Time.deltaTime;

              }
              if (Input.GetKey(KeyCode.UpArrow))
              {
                   transform.position += Vector3.up * Time.deltaTime;
              }

         }
    }
}
