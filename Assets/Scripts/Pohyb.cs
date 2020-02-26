using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pohyb : MonoBehaviour
{
    
    public float speed = 10f;
    public float jumpForce = 25f;
    public float gravity = 30f;
    private Vector3 moveDir = Vector3.zero;

    CharacterController controller;

    void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();

    }

    void Update()
    {
        CharacterController controller = gameObject.GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            moveDir = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDir = transform.TransformDirection(moveDir);
            moveDir *= speed;
            if (Input.GetButtonDown("Jump"))
            {
                moveDir.y = jumpForce;
            }

            if (Input.GetKey(KeyCode.C)) 
            {
                controller.height = 1.0f;
            }
            else {
                controller.height = 2.0f;
            }
        }
        moveDir.y -= gravity * Time.deltaTime;
        controller.Move(moveDir * Time.deltaTime);
    }

}
