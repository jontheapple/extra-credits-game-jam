using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;
	public float leftBound;
	public float rightBound;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		position.x = player.transform.position.x + 5f;
		if (position.x < leftBound) position.x = leftBound;
		if (position.x > rightBound) position.x = rightBound;
		transform.position = position;
	}
}
