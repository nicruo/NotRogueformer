﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

	private Rigidbody2D body;
	private float horizontal;
	private bool jump;
	private bool grounded;

	public float speed = 30;
	public float jumpHeight = 100;
	public float maxVerticalSpeed = 10;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		grounded = true;
	}
	
	// Update is called once per frame
	void Update () {
		jump = Input.GetButton ("Jump");

		horizontal = Input.GetAxis ("Horizontal");
	}

	void FixedUpdate()
	{
		float vertical = 0;
		if (grounded) {
			vertical = jump ? jumpHeight : 0;

			if (jump)
				grounded = false;
		}

		body.velocity = new Vector2 (horizontal * speed, (body.velocity.y < -maxVerticalSpeed)?(-maxVerticalSpeed):(body.velocity.y));

		body.AddForce (new Vector2 (0, vertical));
	}
}
