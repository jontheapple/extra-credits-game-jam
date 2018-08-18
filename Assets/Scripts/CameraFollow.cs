using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 position = transform.position;
		position.x = player.transform.position.x + 5f;
		if (position.x < 1.75f) position.x = 1.75f;
		if (position.x > 41.127f) position.x = 41.127f;
		transform.position = position;
	}
}
