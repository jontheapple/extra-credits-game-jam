using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player") {
			string sceneName = SceneManager.GetActiveScene().name;
			if (sceneName == "Tutorial1") {
				SceneManager.LoadScene("Tutorial2");
			}
			if (sceneName == "Tutorial2") {
				SceneManager.LoadScene("Tutorial3");
			}
			if (sceneName == "Tutorial3") {
				SceneManager.LoadScene("Connor's Shitty 3rd level");
			}
			if (sceneName == "Connor's Shitty 3rd level") {
				SceneManager.LoadScene("Connor2");
			}
			if (sceneName == "Connor2") {
				SceneManager.LoadScene("JonLevel1");
			}
			if (sceneName == "JonLevel1") {
				SceneManager.LoadScene("Connor1");
			}
			if (sceneName == "Connor1") {
				SceneManager.LoadScene("JonLevel2");
			}
			if (sceneName == "JonLevel2") {
				SceneManager.LoadScene("MainMenu");
			}
		}
	}
}
