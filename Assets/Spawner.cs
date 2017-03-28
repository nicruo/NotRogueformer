using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject obj;

	public float StartTime;
	public float RepeatRate;
	public float DestroyTime;

	// Use this for initialization
	void Start () {
		InvokeRepeating ("Spawn", StartTime, RepeatRate);
	}

	void Spawn()
	{
		GameObject newObj;
		newObj = GameObject.Instantiate (obj, this.transform.position, this.transform.rotation);
		GameObject.Destroy (newObj, DestroyTime);
	}

	// Update is called once per frame
	void Update () {
		
	}
}
