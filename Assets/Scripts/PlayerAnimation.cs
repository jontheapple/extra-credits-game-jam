using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class PlayerAnimation : MonoBehaviour {
	public bool loop;
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
			if (loop) {
				frame %= sprites.Length;
			} else if (frame >= sprites.Length) {
				frame = sprites.Length - 1;
			}
		}
		
		spr.sprite = sprites[frame];
    }
}