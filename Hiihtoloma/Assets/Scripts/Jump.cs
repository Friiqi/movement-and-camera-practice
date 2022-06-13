using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
	[Range(1,10)]
	public	float jumpVelocity;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown ("Jump")) 
		{
			GetComponent<Rigidbody> ().velocity = Vector2.up * jumpVelocity;
		}

	}
}
