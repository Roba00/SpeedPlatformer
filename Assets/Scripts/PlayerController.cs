using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Rigidbody playerRigidbody;
    public bool isGrounded = false;
    public Vector3 playerVector;
    public Transform playerTransform;

	// Use this for initialization
	void Start ()
    {
        Debug.Log("Game has started running!");
	}
	
	// Update is called once per frame
	void Update ()
    {
		if (isGrounded)
        {
            if (Input.GetKeyDown("up"))
            {
                playerRigidbody.AddForce(transform.up * 400);
            }
        }
        if (Input.GetKey("left"))
        {
            playerRigidbody.AddForce(-transform.right * 10);
        }
        if (Input.GetKey("right"))
        {
            playerRigidbody.AddForce(transform.right * 10);
        }
        if (Input.GetKey("x"))
        {
            playerRigidbody.AddForce(-transform.up * 10);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        isGrounded = true;
    }
    private void OnCollisionExit(Collision collision)
    {
        isGrounded = false;
    }
}