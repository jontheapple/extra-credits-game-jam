using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalMover : MonoBehaviour {
    public float Speed = 1;
    public float Aptitude = 1;
	public bool Horizontal = false;

    private Vector3 originalPosition;
    private float travelCounter = 0;

    // Use this for initialization
    void Start () {
        originalPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        travelCounter += Global.deltaTime;
        float x = 0;
        float y = 0;
        if (Horizontal) {
			x = Mathf.Sin(travelCounter * Speed) * Aptitude;
		} else {
			y = Mathf.Sin(travelCounter * Speed) * Aptitude;
		}
        transform.position = originalPosition + new Vector3(x, y, 0);
	}
}
