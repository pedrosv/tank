using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour {

    private Rigidbody2D rb;
    public float moveSpeed;

    private Vector2 moveInput;
    private Vector2 moveVelocity;

 

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        moveInput = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        moveVelocity = moveSpeed * moveInput;

	}

    private void FixedUpdate()
    {
        rb.velocity = moveVelocity;
    }
}
