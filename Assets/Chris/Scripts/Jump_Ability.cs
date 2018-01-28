using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump_Ability : MonoBehaviour {

	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate() {

	}

	void OnTriggerStay2D(Collider2D obj) {

		//the player pressed the space bar
		if (Input.GetKeyDown ("space")) {

			//they are jumping off another robot, or the ground
			if(obj.gameObject.tag == "Inmate" || obj.gameObject.tag == "Ground") {
		 
				rb.AddForce (new Vector2 (0, 2), ForceMode2D.Impulse);
			}
		}
	}
}
