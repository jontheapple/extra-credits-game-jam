using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	// Use this for initialization
	public AudioClip JumpSound;
	public AudioClip DoubleJumpSound;
	
	public AudioSource MusicSource;
	public AudioSource MusicSource1;
	
	private PlayerController controller;
	
	void Start () {
		MusicSource.clip = JumpSound;
		MusicSource1.clip = DoubleJumpSound;
		
		
		controller = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		if (controller.grounded && Input.GetButtonDown("Jump")){
			MusicSource.Play();
		}
		if (!controller.grounded && Input.GetButtonDown("Jump") && controller.doublejump){
			MusicSource1.Play();
		}
	}
}
