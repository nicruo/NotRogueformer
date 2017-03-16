using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {

	private Rigidbody2D body;
	private float horizontal;
	private bool jump;

	public float speed = 30;
	public float jumpHeight = 100;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		jump = Input.GetButtonDown ("Jump");
		horizontal = Input.GetAxis ("Horizontal");
	}

	void FixedUpdate()
	{
		body.AddForce (new Vector2 (horizontal * speed, jump?jumpHeight:0 ));
	}
}
