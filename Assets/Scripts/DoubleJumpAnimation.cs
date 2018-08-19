using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleJumpAnimation : MonoBehaviour {
	public float frameSeconds = 1;
	public Sprite[] sprites;

	private SpriteRenderer spr;
	private int frame = 0;
	private float deltaTime = 0;

	// Use this for initialization
	void Start () {
		spr = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		deltaTime += Global.deltaTime;
		while (deltaTime >= frameSeconds) {
			deltaTime -= frameSeconds;
			frame++;
		}
		
		if (frame < sprites.Length) {
			spr.sprite = sprites[frame];
		} else {
			GameObject.Destroy(gameObject);
		}
	}
}
