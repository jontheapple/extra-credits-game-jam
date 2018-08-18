using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GroundCheck : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 acceleration;
    private Vector2 lastVelocity;
    // Use this for initialization
    void Start()
    {
        rb2d = transform.parent.GetComponent<Rigidbody2D>();
        lastVelocity = rb2d.velocity;
    }

    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
        acceleration = (rb2d.velocity - lastVelocity) / Time.fixedDeltaTime;
        lastVelocity = rb2d.velocity;
    }

    void OnTriggerStay2D(Collider2D coll)
    {
        if (acceleration.y == 0)
        {
            transform.parent.GetComponent<PlayerController>().grounded = true;
            transform.parent.GetComponent<PlayerController>().doublejump = true;
            //Debug.Log("Land");
        }
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        transform.parent.GetComponent<PlayerController>().grounded = false;
        //Debug.Log("Jump");
    }
}
