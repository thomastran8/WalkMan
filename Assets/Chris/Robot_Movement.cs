using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_Movement : MonoBehaviour {

	Rigidbody2D rb; //to move the robot(s)

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		rb.velocity = 
	}
}
