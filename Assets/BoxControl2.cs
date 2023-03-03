using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxControl2 : MonoBehaviour
{

    public KeyCode leftKey  = KeyCode.LeftArrow; // Change to KeyCode.LeftArrow in inspector
public KeyCode rightKey = KeyCode.RightArrow;
public float   speed = 1.0f;

private Vector2 _moveVelocity;
public Rigidbody2D _rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         Vector2 moveInput = Vector2.zero;
    if(Input.GetKey(leftKey))
    {
        moveInput = Vector2.left;
    }

    if(Input.GetKey(rightKey))
    {
        moveInput = Vector2.right;
    }

    _moveVelocity = moveInput * speed * Time.deltaTime;
    _rigidBody.velocity = _moveVelocity;
    }
}
