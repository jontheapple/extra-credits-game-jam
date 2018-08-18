using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Global : MonoBehaviour {
	public static float time = 0;
	public static float deltaTime;
	public static float speed = 1;

	//public GameObject player;
	
	void Update () {
		deltaTime = Time.deltaTime * speed;
		time += deltaTime;

		//PlayerController controller = player.GetComponent<PlayerController>();
		//if (Input.GetButtonDown("TimeSlow")) {
		//	controller.activateTimeSlow();
		//} else if (Input.GetButtonUp("TimeSlow")) {
		//	controller.deactivateTimeSlow();
		//}
	}
}
