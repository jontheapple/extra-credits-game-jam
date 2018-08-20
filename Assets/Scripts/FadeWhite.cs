using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeWhite : MonoBehaviour {
	public float FadeRate;
	private Image image;
	private float targetAlpha;
	private bool fading;

	private float timer;

	// Use this for initialization
	void Start () {
		this.image = this.GetComponent<Image>();
		if(this.image==null)
		{
			Debug.LogError("Error: No image on "+this.name);
		}
		Color color = this.image.color;
		color.a = 0;
		this.image.color = color;
		this.targetAlpha = this.image.color.a;
		fading = false;
	}

	// Update is called once per frame
	void Update () {
		Color curColor = this.image.color;
		float alphaDiff = Mathf.Abs(curColor.a-this.targetAlpha);
		if (alphaDiff>0.0001f) {
			curColor.a = Mathf.Lerp(curColor.a,targetAlpha,this.FadeRate*Time.deltaTime);
			this.image.color = curColor;
		}

		if (Input.GetButtonDown("Right") || Input.GetButtonDown("TimeSlow")) {
			FadeIn();
			timer = Time.time;
			fading = true;
		}

		if (fading && Time.time - 3.5f > timer) {
			SceneManager.LoadScene("Credits");
		}
	}

	public void FadeOut() {
		this.targetAlpha = 0.0f;
	}

	public void FadeIn(){
		this.targetAlpha = 1.0f;
	}
}