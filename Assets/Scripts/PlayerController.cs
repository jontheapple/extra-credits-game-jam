using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float maxSpeed = 10f;
	bool facingRight = true;

	bool grounded = false;
	bool doublejump = true;
	public Transform groundCheck;
	float groundRadius = 0.2f;
	public LayerMask whatIsGround;
	
	private Rigidbody2D rb2d;
	private float jumpForce = 9f;
	private float dbljumpForce = 8f;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}

	void Update() {
		if (grounded && Input.GetButtonDown("Jump")) {
			rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
			grounded = false;
		} else if (!grounded && doublejump && Input.GetButtonDown("Jump")) {
			rb2d.velocity = new Vector2(rb2d.velocity.x, dbljumpForce);
			doublejump = false;
		}
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
		if (grounded) doublejump = true;


		float move = Input.GetAxis("Horizontal");

		rb2d.velocity = new Vector2(move * maxSpeed, rb2d.velocity.y);

		if(move > 0 && !facingRight) {
			Flip();
		} else if (move < 0 && facingRight) {
			Flip();
		}
	}

	void Flip() {
		facingRight = !facingRight;
		Vector3 theScale = transform.localScale;
		theScale.x *= -1;
		transform.localScale = theScale;
	}
}
