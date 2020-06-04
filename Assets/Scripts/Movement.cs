using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed = 10f;
    private float jumpHeight = 5;
    private bool canJump = false;
    private bool isGrounded = true;
    private GameObject player;
    private Rigidbody rb;
    private Rigidbody planetRB;
    private Transform jumpTarget;

    private void Awake()
    {
        jumpTarget = GameObject.Find("JumpTarget").GetComponent<Transform>();
        planetRB = GameObject.Find("Planet").GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        isGrounded = true;
        canJump = false;
        rb = player.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (canJump)
        {
            canJump = false;
            player.transform.Translate(jumpTarget.transform.position * jumpHeight * Time.deltaTime);
        }
        else
        {
            rb.AddForce((planetRB.position - transform.position).normalized * speed);
        }

        if (isGrounded)
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                canJump = true;
            }
        }

        if (Input.GetKey(KeyCode.W))
        {
            player.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.S))
        {
            player.transform.Translate(Vector3.back * speed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            player.transform.Rotate(0.0f, -90.0f * Time.deltaTime, 0.0f, Space.Self);
        }

        if (Input.GetKey(KeyCode.D))
        {
            player.transform.Rotate(0.0f, 90.0f * Time.deltaTime, 0.0f, Space.Self);
        }
        
    }

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
}
