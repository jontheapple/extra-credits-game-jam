using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Killbox : MonoBehaviour {

	public AudioClip Death;
	
	public AudioSource MusicSource;
	
	// Use this for initialization
	void Start () {
		MusicSource.clip = Death;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		PlayerController player = other.gameObject.GetComponent<PlayerController>();
		if (player != null) {
			MusicSource.Play();
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}
}
