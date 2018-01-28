using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrequencyReceiver : MonoBehaviour {
	//shown when player's frequency is close to this robot's
	public GameObject lightningBolt; 

    private float playerRefSpeed = 0;
    private FrequencyController fc;
    [Range(0.0f, 10.0f)]
    [SerializeField]
    private float frequencyChannel;
    [SerializeField]
    private bool randomizeStartingFreq;

    private GameObject playerGO;
    private float frequencyDiff;

	private float lightningFreqRange = 0.25f;


    // Use this for initialization
    void Start () {
        playerGO = GameObject.FindWithTag("Player");
        fc = playerGO.GetComponent<FrequencyController>();
        if (randomizeStartingFreq)
        {
            frequencyChannel = (int) Random.Range(1,10.99f);
            Debug.Log(frequencyChannel);
        }
    }
	
	// Update is called once per frame
	void Update () {
        float receivingFrequency = fc.getCurrentFreq();
        frequencyDiff = Mathf.Abs(receivingFrequency - frequencyChannel);

		if (frequencyDiff <= lightningFreqRange) //display lightning bolt
			lightningBolt.SetActive(true);
		else
			lightningBolt.SetActive(false);
	}

    // The amount of frequency difference between the player's frequency and this robot
    public float getFrequencyDiff()
    {
        return frequencyDiff;

    }
}
