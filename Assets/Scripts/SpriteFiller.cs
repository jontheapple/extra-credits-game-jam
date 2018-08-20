using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteFiller : MonoBehaviour {
	public GameObject Spike;
	public GameObject Box;
	public GameObject AngryFace;
	public bool HideOriginalSprite;

	// Use this for initialization
	void Start () {
		if (HideOriginalSprite) {
			GetComponent<SpriteRenderer>().enabled = false;
		}

		//if (GetComponent<Mover>() != null && GetComponent<Mover>().Speed != Vector2.zero) { // angry box
			Vector3 scale = transform.localScale;
			GameObject box = GameObject.Instantiate(Box, new Vector3(transform.position.x, transform.position.y, transform.position.z + 0.00001f), Quaternion.identity);
			box.transform.parent = transform;
			box.transform.localScale = Vector3.one;
			GameObject af = GameObject.Instantiate(AngryFace, transform.position, Quaternion.identity);
			af.transform.parent = transform;
		/*
		} else { // spikeballs
			Vector3 scale = transform.localScale;
			for (int i = 0; i < scale.y; i++) {
				for (int j = 0; j < scale.x; j++) {
					GameObject spike = GameObject.Instantiate(Spike, new Vector3(transform.position.x + j * 0.32f - scale.x * 0.16f + 0.16f, transform.position.y + i * 0.32f - scale.y * 0.16f + 0.16f, 0), Quaternion.identity);
					spike.transform.parent = transform;
				}
			}
		*/	
			/* random scattered
			Vector3 scale = transform.localScale;
			float amount = Mathf.Sqrt(scale.x * scale.y);
			for (int i = 0; i < amount; i++) {
				float x = Random.Range(transform.position.x + scale.x * -0.15f + 0.15f, transform.position.x + scale.x * 0.15f - 0.15f);
				float y = Random.Range(transform.position.y + scale.y * -0.15f + 0.15f, transform.position.y + scale.y * 0.15f - 0.15f);
				GameObject go = GameObject.Instantiate(Spike, new Vector3(x, y, 0), Quaternion.identity);
				go.transform.parent = transform;
			}
			*/
		//}
	}
}
