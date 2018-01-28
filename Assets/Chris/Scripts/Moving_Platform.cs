using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moving_Platform : MonoBehaviour {

	public Vector2 forward = new Vector2(1.0f, 0); //this is the forward direction

	private int speedFactor = 50;
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {
		
		rb.velocity = forward * speedFactor;
	}

	void OnCollisionEnter2D() {
		forward = -forward;
	}

}
