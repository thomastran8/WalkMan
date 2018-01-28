using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//[RequireComponent(typeof())]
public class FrequencyController : MonoBehaviour {
    [Range(0.0f, 10.0f)]
    [SerializeField]
    private float playerStartFrequency;  // The frequency the player starts with
    private float currentFrequency; // The frequency the player changes during gameplay
    [SerializeField]
    private float tuningSpeed;
    private Slider frequencySlider;

	// Use this for initialization
	void Start () {
        // Check if player UI exists
        GameObject playerUI = GameObject.FindGameObjectWithTag("PlayerUI");
        frequencySlider = playerUI.transform.Find("RadioBar").GetComponent<Slider>();
        currentFrequency = playerStartFrequency;
        frequencySlider.value = playerStartFrequency;
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
        frequencySlider.value = currentFrequency;
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
