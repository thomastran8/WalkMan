﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

//[RequireComponent(typeof())]
public class FrequencyController : MonoBehaviour {
    [Range(1.0f, 10.0f)]
    [SerializeField]
    private float playerStartFrequency;  // The frequency the player starts with
    private float currentFrequency; // The frequency the player changes during gameplay
    [SerializeField]
    private float tuningSpeed;
    private Slider frequencySlider;
    private Text freqNum;
    private RectTransform dial;
    [SerializeField]
    private int dialTurn;

	// Use this for initialization
	void Start () {
        // Check if player UI exists
        GameObject playerUI = GameObject.FindGameObjectWithTag("PlayerUI");
        frequencySlider = playerUI.transform.Find("RadioBar").GetComponent<Slider>();
        currentFrequency = playerStartFrequency;
        frequencySlider.value = playerStartFrequency;
        freqNum = playerUI.transform.Find("FreqNum").GetComponent<Text>();
        dial = playerUI.transform.Find("Dial").GetComponent<RectTransform>();
        displayFreq();
    }
	
	// Update is called once per frame
	void Update () {
        float radioTuneDir = Input.GetAxisRaw("RadioTune") * tuningSpeed;
        if (radioTuneDir != 0)
        {
            changeFreq(radioTuneDir);
            displayFreq();
        }
	}

    private void changeFreq(float dir)
    {
        float startingFrequency = currentFrequency;
        currentFrequency += dir;
        currentFrequency = Mathf.Clamp(currentFrequency, 1, 10);
        frequencySlider.value = currentFrequency;
        //Debug.Log(currentFrequency);
        if (startingFrequency != currentFrequency)
        {
            if (dir < 0)
                dial.Rotate(new Vector3(0, 0, 1) * dialTurn);
            else
                dial.Rotate(new Vector3(0, 0, -1) * dialTurn);
        }
    }

    // The player's current frequency
    public float getCurrentFreq()
    {
        return currentFrequency;
    }

    public void displayFreq()
    {
        float truncatedNum = (float) Math.Truncate(100 * currentFrequency) / 100;
        freqNum.text = truncatedNum.ToString();
    }
}
