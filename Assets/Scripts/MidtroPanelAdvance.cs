using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MidtroPanelAdvance : MonoBehaviour {
	public Sprite panel1;
	public Sprite panel2;
	
	private bool firstRight; //handles the player holding right from the previous scene
	private int current;

	// Use this for initialization
	void Start () {
		current = 1;
		firstRight = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Right") || Input.GetButtonDown("TimeSlow")) {
			if (firstRight) {
				firstRight = false;
				return;
			}
			if (current == 1){
				GetComponent<Image>().sprite = panel2;
				current = 2;
			} else if (current == 2) {
				SceneManager.LoadScene("Connor2");
			}
		} else if (Input.GetButtonDown("Left")) {
			switch (current) {
				case 1:
					break;
				case 2:
					GetComponent<Image>().sprite = panel1;
					current = 1;
					break;
			}
			
		}
	}
}
