using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 10f;
	bool facingRight = true;

	public bool grounded = false;
	public bool doublejump = true;
	public GameObject DoubleJumpEffect;
	private float jumpForce = 9f;
	private float dbljumpForce = 8f;

	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	
	private Rigidbody2D rb2d;
	
	private float timeSlowFactor = 1;
	private Vector3 startingPosition;
	private float move;

	public float Horizontal { get { return move; } }

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		startingPosition = transform.position;
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetButtonDown("Cancel")){
			SceneManager.LoadScene("MainMenu");
		}

		if (grounded && Input.GetButtonDown("Jump")) {
			rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce * timeSlowFactor);
		} else if (!grounded && doublejump && Input.GetButtonDown("Jump")) {
			GameObject.Instantiate(DoubleJumpEffect, transform.position, Quaternion.identity);
			rb2d.velocity = new Vector2(rb2d.velocity.x, dbljumpForce * timeSlowFactor);
			doublejump = false;
		}
		if (Input.GetButtonDown("TimeSlow")) {
			activateTimeSlow();
		} else if (Input.GetButtonUp("TimeSlow")) {
			deactivateTimeSlow();
		}
	}
	
	void FixedUpdate () {
		move = Input.GetAxis("Horizontal");

		rb2d.velocity = new Vector2(move * maxSpeed * timeSlowFactor, rb2d.velocity.y);

		if(move > 0 && !facingRight) {
			Flip();
		} else if (move < 0 && facingRight) {
			Flip();
		}
	}

	void Flip() {
		facingRight = !facingRight;
		GetComponent<SpriteRenderer>().flipX = !GetComponent<SpriteRenderer>().flipX;
	}

	public void activateTimeSlow() {
		timeSlowFactor = TimeStatic.timeSlowFactor;
		rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y * timeSlowFactor);
		rb2d.gravityScale = rb2d.gravityScale * timeSlowFactor * timeSlowFactor;
	}

	public void deactivateTimeSlow() {
		rb2d.velocity = new Vector2(rb2d.velocity.x, rb2d.velocity.y / timeSlowFactor);
		rb2d.gravityScale = rb2d.gravityScale / timeSlowFactor / timeSlowFactor;
		timeSlowFactor = 1;
	}

	public void Reset() {
		rb2d.velocity = Vector2.zero;
		transform.position = startingPosition;
	}
}
