using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OLD_Robot_Movement : MonoBehaviour {

	Rigidbody2D rb; //to move the robot(s)
	private int maxSpeed = 10;

	public float playerFrequency; //the frequency the player can change
	public float robotFrequency; //this robot's frequency

	float GetXVelocityRelativeToFrequency() {

		float diffInFrequecies = Mathf.Abs (playerFrequency - robotFrequency);
		float speedFactor = maxSpeed - diffInFrequecies;
		float factorOfMaxSpeed = maxSpeed / 3.0f;
		//half as slow, felt too fast at max speed
		return (Input.GetAxisRaw ("Horizontal") * speedFactor) / factorOfMaxSpeed;
	}

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate() {
		
		rb.velocity = new Vector2 (GetXVelocityRelativeToFrequency(), rb.velocity.y);
	}
}
