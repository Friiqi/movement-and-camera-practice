using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour {

	Vector3 cameraOffset;
	Vector3 cameraRotation;
	GameObject playerObj;
	public float speedHorizontal = 2.0f;
	public float speedVertical = 2.0f;
	public float mousexAxis = 0.0f;
	public float mouseyAxis = 0.0f;
	// Use this for initialization
	void Start () {
		playerObj = GameObject.Find ("Player");
		cameraOffset = new Vector3 (0, 1, -5);
	}
	
	// Update is called once per frame
	void Update () {
		
			transform.position = playerObj.transform.position + cameraOffset;

		if (Input.GetMouseButton (1)) {
			mousexAxis += speedHorizontal * Input.GetAxis ("Mouse X");
			mouseyAxis -= speedVertical * Input.GetAxis ("Mouse Y");

			transform.eulerAngles = new Vector3 (mouseyAxis, mousexAxis, 0.0f);
		}
	}
}
