using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrequencyReceiver : MonoBehaviour {
    private float playerRefSpeed = 0;
    private FrequencyController fc;
    [Range(0.0f, 10.0f)]
    [SerializeField]
    private float frequencyChannel;
    private bool randomizeStartingFreq;
    private GameObject playerGO;
    private float frequencyDiff;

    // Use this for initialization
    void Start () {
        playerGO = GameObject.FindWithTag("Player");
        fc = playerGO.GetComponent<FrequencyController>();
    }
	
	// Update is called once per frame
	void Update () {
        float receivingFrequency = fc.getCurrentFreq();
        frequencyDiff = Mathf.Abs(receivingFrequency - frequencyChannel);
	}

    // The amount of frequency difference between the player's frequency and this robot
    public float getFrequencyDiff()
    {
        return frequencyDiff;
    }
}
