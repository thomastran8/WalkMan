using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Robot_Movement))]
public class FrequencyController : MonoBehaviour {
    [SerializeField]
    private float currentFrequency;
    [SerializeField]
    private float tuningSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float radioTuneDir = Input.GetAxisRaw("RadioTune") * tuningSpeed;
        if (radioTuneDir != 0)
        {
            changeFreq(radioTuneDir);
        }
	}

    private void changeFreq(float dir)
    {
        float startingFrequency = currentFrequency;
        currentFrequency += dir;
        currentFrequency = Mathf.Clamp(currentFrequency, 1, 10);
        //Debug.Log(currentFrequency);
        if (startingFrequency == currentFrequency)
        {
            //Debug.Log("No Change");
        }
    }

    // The player's current frequency
    public float getCurrentFreq()
    {
        return currentFrequency;
    }
}
