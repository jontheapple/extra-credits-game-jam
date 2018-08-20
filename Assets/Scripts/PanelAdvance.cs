using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PanelAdvance : MonoBehaviour {
	public Sprite panel1;
	public Sprite panel2;
	public Sprite panel3;

	private bool right; //Whether or not Right is being pressed. Panels should only advance once per Right-press
	private bool left;
	private int current;

	// Use this for initialization
	void Start () {
		current = 1;
		right = false;
		left = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (right) {
			if (Input.GetAxis("Horizontal") <= 0) right = false;
			return;
		}
		if (left) {
			if (Input.GetAxis("Horizontal") >= 0) left = false;
			return;
		}

		if (Input.GetAxis("Horizontal") > 0 || Input.GetButtonDown("TimeSlow")) {
			if (Input.GetAxis("Horizontal") > 0) right = true;
			if (current == 1){
				GetComponent<Image>().sprite = panel2;
				current = 2;
			} else if (current == 2) {
				GetComponent<Image>().sprite = panel3;
				current = 3;
			} else if (current == 3) {
				SceneManager.LoadScene("Tutorial1");
			}
		} else if (Input.GetAxis("Horizontal") < 0) {
			left = true;
			switch (current) {
				case 1:
					break;
				case 2:
					GetComponent<Image>().sprite = panel1;
					current = 1;
					break;
				case 3:
					GetComponent<Image>().sprite = panel2;
					current = 2;
					break;
			}
			
		}
	}
}
