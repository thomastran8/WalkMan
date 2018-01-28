using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour {
    private int currentScene;

	// Use this for initialization
	void Start () {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void loadNextScene()
    {
        SceneManager.LoadScene(currentScene+1);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void resetGame()
    {
        SceneManager.LoadScene(currentScene);
    }
}
