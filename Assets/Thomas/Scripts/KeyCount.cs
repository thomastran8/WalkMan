using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCount : MonoBehaviour {
    private static int numKeys = 0;
    private static int keysInLevel;
    private static SceneLoader sceneLoad;

    // Use this for initialization
    void Start () {
        keysInLevel = GameObject.FindGameObjectsWithTag("Key").Length;
        sceneLoad = GameObject.FindGameObjectWithTag("SceneLoader").GetComponent<SceneLoader>();
        numKeys = 0;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public int getNumKeys()
    {
        return numKeys;
    }

    public static void incrementKeyCount()
    {
        numKeys++;
        if (numKeys >= keysInLevel)
        {
            sceneLoad.loadNextScene();
        }
    }
}
