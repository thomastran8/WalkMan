using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_Movement : MonoBehaviour {

	Rigidbody2D rb; //to move the robot(s)
    [SerializeField]
	private float maxSpeed;

	//public float playerFrequency; //the frequency the player can change
	//public float robotFrequency; //this robot's frequency

    private FrequencyReceiver freqReceive;

	// Use this for initialization
	void Start () {
		
		rb = GetComponent<Rigidbody2D> ();
        freqReceive = gameObject.GetComponent<FrequencyReceiver>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {
		
		rb.velocity = new Vector2 (GetXVelocityRelativeToFrequency(), rb.velocity.y);
	}

    float GetXVelocityRelativeToFrequency()
    {

        //float diffInFrequecies = Mathf.Abs (playerFrequency - robotFrequency);
        //float speedFactor = maxSpeed - diffInFrequecies;
        float speedFactor = maxSpeed - freqReceive.getFrequencyDiff();
        float factorOfMaxSpeed = maxSpeed / 3.0f;
        //half as slow, felt too fast at max speed
        return (Input.GetAxisRaw("Horizontal") * speedFactor) / factorOfMaxSpeed;
    }
}
