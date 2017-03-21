using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject obj;

	private Vector3 distance;

	public float maxDistance = 4;

	// Use this for initialization
	void Start () {
		distance = transform.position - obj.transform.position;
	}
	
	// Update is called once per frame
	void Update () {

//		if (obj.transform.position.x >= 17.6 || obj.transform.position.x <= 5)
//			return;

		Vector3 newDistance = transform.position - obj.transform.position;

		transform.position = obj.transform.position + distance;

		if (Mathf.Abs (newDistance.x) > maxDistance) {
			distance = newDistance;


		}
	}
}
