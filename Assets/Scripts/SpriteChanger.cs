using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpriteChanger : MonoBehaviour {
	public string[] LevelNames;
	public Sprite[] Replacements;

	// Use this for initialization
	void Start () {
		string sceneName = SceneManager.GetActiveScene().name;
		int levelIndex = System.Array.IndexOf(LevelNames, sceneName);
		if (levelIndex >= 0) {
			GetComponent<SpriteRenderer>().sprite = Replacements[System.Array.IndexOf(LevelNames, sceneName)];
		}
	}
}
