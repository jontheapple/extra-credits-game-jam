using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject target; //Object Camera will follow, probably the player
	public float leftBound; //Camera will not go past this point to the left
	public float rightBound; //Camera will not go past this point to the right
	public bool followX; //Should the camera follow the target's x position?
	public float xOffset; //if followX is true, how should the camera be offset? 0 means centered
	public bool followY;
	public float yOffset;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		if (followX) {
			position.x = target.transform.position.x + xOffset;
		}
		if (followY) {
			position.y = target.transform.position.y + yOffset;
		}
		if (position.x < leftBound) position.x = leftBound;
		if (position.x > rightBound) position.x = rightBound;
		transform.position = position;
	}
}
