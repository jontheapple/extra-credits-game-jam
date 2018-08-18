﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuFunctions : MonoBehaviour {

	public GameObject start;
	public GameObject quit;

	public void StartGame() {
		SceneManager.LoadScene("Tutorial1");
	}

	public void Quit() {
		#if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
		#else
      Application.Quit ();
		#endif
  }

	public void UnhighlightStart() {
		start.GetComponent<Image>().enabled = false;
	}

	public void UnhighlightQuit() {
		quit.GetComponent<Image>().enabled = false;
	}
}