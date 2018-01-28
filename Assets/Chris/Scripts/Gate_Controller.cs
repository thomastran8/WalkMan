using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_Controller : MonoBehaviour {

	//example of vertical gate
	private Vector2 forward = new Vector2(0, .01f);

	private float end; //stop at the length of the gate
	private float start;

	public bool isActive = false;

	// Use this for initialization
	void Start () {
		start = this.transform.position.y;

		float height = GetComponent<SpriteRenderer> ().bounds.size.y;
		end = start + height;
	}
	
	// Update is called once per frame
	void Update () {
		
		//only move if gate is activated by pressure plate
		if (isActive) {
			Move ();
		} 

		else {
			MoveBack ();
		}
	}

	//open the gate according to the direction
	public void Move() {

		//move if the gate still has room to move
		if (this.transform.position.y < end) {
			this.transform.Translate (forward);
		}
	}

	public void MoveBack() {
		
		if (this.transform.position.y > start) {
			this.transform.Translate (-forward);
		}
	}
}
