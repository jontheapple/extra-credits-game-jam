using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	private float displayTime;
	private bool gameDone;

	// Use this for initialization
	void Start () {
		gameDone = false;
		if (SceneManager.GetActiveScene().name == "Tutorial1") {
			TimeStatic.timeStart = Time.time;
			displayTime = 0;
		} else {
			displayTime = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameDone){
			displayTime = Time.time - TimeStatic.timeStart;
			if (SceneManager.GetActiveScene().name == "Credits") {
				Debug.Log("Final time is " + displayTime);
			} else{
				Debug.Log("Timer is " + displayTime);
			}
		}
	}

	void OnGUI() {
		string minutes = Mathf.Floor(displayTime / 60).ToString("00");;
		string seconds = (displayTime % 60).ToString("00");
		
		GUI.Label(new Rect(10,10,250,100), minutes + ":" + seconds);
	}
}
