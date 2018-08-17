using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : PhysicsObject {

  public float maxSpeed = 7;
  public float jumpTakeOffSpeed = 7;

  private SpriteRenderer spriteRenderer;
	private bool doublejumped;
	private bool facingRight;

  // Use this for initialization
  void Awake () 
  {
    spriteRenderer = GetComponent<SpriteRenderer> ();
		facingRight = true;
		doublejumped = false;
  }

  protected override void ComputeVelocity()
  {
		Vector2 move = Vector2.zero;
		move.x = Input.GetAxis ("Horizontal");

    if (Input.GetButtonDown ("Jump") && grounded) {
        velocity.y = jumpTakeOffSpeed;
    } else if (Input.GetButtonUp ("Jump")) {
        if (velocity.y > 0) {
            velocity.y = velocity.y * 0.5f;
        }
    }

    if (facingRight) {
			if (move.x < 0f){
				spriteRenderer.flipX = !spriteRenderer.flipX;
				facingRight = false;
			}
		} else {
			if (move.x > 0f){
				spriteRenderer.flipX = !spriteRenderer.flipX;
				facingRight = true;
			}
		}

    targetVelocity = move * maxSpeed;
	}
}