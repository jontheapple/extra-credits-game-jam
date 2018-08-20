using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class IntroPanelAdvance : MonoBehaviour {
	public Sprite panel1;
	public Sprite panel2;
	public Sprite panel3;


	private int current;

	// Use this for initialization
	void Start () {
		current = 1;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetButtonDown("Right") || Input.GetButtonDown("TimeSlow")) {
			if (current == 1){
				GetComponent<Image>().sprite = panel2;
				current = 2;
			} else if (current == 2) {
				GetComponent<Image>().sprite = panel3;
				current = 3;
			} else if (current == 3) {
				SceneManager.LoadScene("Tutorial1");
			}
		} else if (Input.GetButtonDown("Left")) {
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
