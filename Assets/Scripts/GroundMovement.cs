using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour {

    public Rigidbody groundRigidbody;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        groundRigidbody.AddForce(-transform.right * 100000 * Time.deltaTime);
	}
}
