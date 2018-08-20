using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {
	
	public AudioClip Goal;
	
	public AudioSource MusicSource;
	
	private string[] LevelNames = {
		"Tutorial1",
		"Tutorial2",
		"Tutorial3",
		"Connor's Shitty 3rd level",
		"Connor2",
		"JonLevel1",
		"Ben1",
		"Connor1",
		"JonLevel2",
		"Credits"
	};

	// Use this for initialization
	void Start () {
		MusicSource.clip = Goal;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D col) {
		if (col.name == "Player") {
			MusicSource.Play();
			string sceneName = SceneManager.GetActiveScene().name;
			SceneManager.LoadScene(LevelNames[System.Array.IndexOf(LevelNames, sceneName) + 1]);
		}
	}
}
