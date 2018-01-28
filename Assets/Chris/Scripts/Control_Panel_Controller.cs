using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control_Panel_Controller : MonoBehaviour {

	//game object(s) it affects	
	public GameObject gate;
	private Gate_Controller gController;

	// Use this for initialization
	void Start () {
		gController = gate.GetComponent<Gate_Controller> (); //getting the object's script
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D robot) {
		
		//gate is activated by being in front of control panel
		gController.isActive = true;
		Debug.Log ("there's a trigger");
	}

	void OnTriggerExit2D(Collider2D robot) {

		//moved away from control panel, stop moving gate
		gController.isActive = false;
	}
}
