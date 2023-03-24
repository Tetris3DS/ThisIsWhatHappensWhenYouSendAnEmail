using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController2 : MonoBehaviour
{

    public KeyCode leftKey  = KeyCode.LeftArrow; // Change to KeyCode.LeftArrow in inspector
    public KeyCode rightKey = KeyCode.RightArrow;
    public KeyCode upKey = KeyCode.UpArrow;
    public KeyCode downKey = KeyCode.DownArrow;
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
    if(Input.GetKey(upKey))
    {
        moveInput = Vector2.up;
    }
    if(Input.GetKey(downKey))
    {
        moveInput = Vector2.down;
    }

    _moveVelocity = moveInput * speed * Time.deltaTime;
    _rigidBody.velocity = _moveVelocity;
    }
}
