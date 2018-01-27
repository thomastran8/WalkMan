using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_Controller : MonoBehaviour {

	//example of vertical gate
	private Vector2 forward = new Vector2(0, 1);
	private Vector2 back = new Vector2(0, -1);

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//open the gate according to the direction
	public void Move() {
		this.transform.Translate (forward);
	}
}
