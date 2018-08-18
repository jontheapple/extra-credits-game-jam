using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerAnimation : MonoBehaviour {
	public float IdleFrameSeconds = 1;
	public Sprite[] idle;
	public float RunningFrameSeconds = 0.25f;
	public Sprite[] running;
	public float AirborneFrameSeconds = 1;
	public Sprite[] airborne;

	private SpriteRenderer spr;
	private PlayerController controller;
	private int frame = 0;
	private float deltaTime = 0;
	private Sprite[] currentAnimation;
	private float frameSeconds;
     
	// Use this for initialization
	void Start () {
		spr = GetComponent<SpriteRenderer> ();
		controller = GetComponent<PlayerController>();
		currentAnimation = idle;
		frameSeconds = IdleFrameSeconds;
	}
     
    // Update is called once per frame
	void Update () {
		if (!controller.grounded) {
			if (currentAnimation != airborne) {
				currentAnimation = airborne;
				frameSeconds = IdleFrameSeconds;
				deltaTime = frame = 0;
			}
		} else if (controller.Horizontal != 0) {
			if (currentAnimation != running) {
				currentAnimation = running;
				frameSeconds = RunningFrameSeconds;
				deltaTime = frame = 0;
			}
		} else {
			if (currentAnimation != idle) {
				currentAnimation = idle;
				frameSeconds = AirborneFrameSeconds;
				deltaTime = frame = 0;
			}
		}
		
		deltaTime += Global.deltaTime;
		while (deltaTime >= frameSeconds) {
			deltaTime -= frameSeconds;
			frame++;
			frame %= currentAnimation.Length;
		}
		
		spr.sprite = currentAnimation[frame];
    }
}
