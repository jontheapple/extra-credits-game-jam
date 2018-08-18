using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killbox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		PlayerController player = other.gameObject.GetComponent<PlayerController>();
		if (player != null) {
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
