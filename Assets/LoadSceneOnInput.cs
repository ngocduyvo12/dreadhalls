using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Submit") == 1) {
			// Create a temporary reference to the current scene.
			Scene currentScene = SceneManager.GetActiveScene ();
	
			// Retrieve the name of this scene.
			string sceneName = currentScene.name;
		
			if ((Input.GetAxis("Submit") == 1) && (sceneName == "Title")) {
				SceneManager.LoadScene("Play");
			} else if ((Input.GetAxis("Submit") == 1) && (sceneName == "GameOver")) {
				SceneManager.LoadScene("Title");
			}
		}
	}
}
