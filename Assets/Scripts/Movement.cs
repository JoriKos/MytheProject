﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float turnSpeed;
    //private float jumpHeight = 5f;
    //private bool canJump = false;
    private GameObject player;
    //private bool isGrounded = true;
    //private Rigidbody rb;
    //private Rigidbody groundRB;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        player = GameObject.Find("Player");
        //groundRB = GameObject.Find("Planet").GetComponent<Rigidbody>();
        //isGrounded = true;
        //canJump = false;
        //rb = this.GetComponent<Rigidbody>();
    }

    /*private void FixedUpdate()
    {
        if (canJump)
        {
            canJump = false;
            rb.AddForce(0, 5, 0, ForceMode.Impulse);
        }
    }*/

    private void Update()
    {
        /*if (isGrounded)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                rb.AddForce(0, 5, 0, ForceMode.Impulse);
            }
        }*/

       if (Input.GetKey(KeyCode.W))
       {
           anim.SetBool("Walking", true);
           player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
       }
       else
       {
           anim.SetBool("Walking", false);
       }
        
       if (Input.GetKey(KeyCode.S))
       {
           player.transform.Translate(Vector3.back * speed * Time.deltaTime);
       }

       if (Input.GetKey(KeyCode.A))
       {
           player.transform.Rotate(0.0f, -turnSpeed * Time.deltaTime, 0.0f, Space.Self);
       }

       if (Input.GetKey(KeyCode.D))
       {
           player.transform.Rotate(0.0f, turnSpeed * Time.deltaTime, 0.0f, Space.Self);
       }
       


    }
    /*
    private void OnCollisionEnter(Collision other)
    {
       
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            isGrounded = false;
        }
    }
    */
}
