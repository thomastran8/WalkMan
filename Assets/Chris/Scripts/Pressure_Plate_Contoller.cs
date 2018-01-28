using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pressure_Plate_Contoller : MonoBehaviour {

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

	//only a robot for now will step on a pressure plate
	void OnCollisionEnter2D(Collision2D robot) {
		
		//gate is activated by the pressure plate
		gController.isActive = true;
	}

	//a robot stepped off the plate
	void OnCollisionExit2D(Collision2D robot) {

		//robot stepped off, stop moving gate
		gController.isActive = false;
	}


}
