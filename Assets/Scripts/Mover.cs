using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {
    public Vector2 Speed;
    public Vector2 HorizontalBounds;
    public Vector2 VerticalBounds;

    private Vector3 originalPosition;
    private float travelCounter = 0;

    // Use this for initialization
    void Start () {
        originalPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
        travelCounter += Time.deltaTime;
        float x = 0;
        float y = 0;
        if (-HorizontalBounds.x + HorizontalBounds.y > 0) {
            x = Mathf.PingPong(Speed.x * travelCounter - HorizontalBounds.x, -HorizontalBounds.x + HorizontalBounds.y) + HorizontalBounds.x;
        }
        if (-VerticalBounds.x + VerticalBounds.y > 0) {
            y = Mathf.PingPong(Speed.y * travelCounter - VerticalBounds.x, -VerticalBounds.x + VerticalBounds.y) + VerticalBounds.x;
        }
        transform.position = originalPosition + new Vector3(x, y, 0);
	}
}
