using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallScript : MonoBehaviour {

	private Rigidbody2D body;
	private SpriteRenderer renderer;

	public float timeToFall;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody2D> ();	
		renderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.tag == "Player") {
			StartCoroutine ("DelayFall");
			GameObject.Destroy (this.gameObject, 1f);
		}


	}

	IEnumerator DelayFall()
	{
		yield return new WaitForSeconds(timeToFall);
		body.isKinematic = false;

		for (float i = 1.0f; i >= 0.0f; i -= 0.1f) {
			var color = renderer.color;
			color.a = i;
			renderer.color = color;
			yield return new WaitForSeconds(0.1f);
		}


	}
}
