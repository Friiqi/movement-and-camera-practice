using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour {
	public Transform player;
	Vector3 cameraOffset;
	Vector3 cameraRotation;

	public float speedHorizontal = 2.0f;
	public float speedVertical = 2.0f;
	public float mousexAxis = 0.0f;
	public float mouseyAxis = 0.0f;
	public float smooth = 5.0f;
	// Use this for initialization
	void Start () {
		
		cameraOffset = new Vector3 (0, 1, -10);

	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position = player.position + cameraOffset;

		if (Input.GetMouseButton (1)) {
			mousexAxis += speedHorizontal * Input.GetAxis ("Mouse X");
			mouseyAxis -= speedVertical * Input.GetAxis ("Mouse Y");

			//transform.eulerAngles = new Vector3 (mouseyAxis, mousexAxis, 0.0f);
			Quaternion target = Quaternion.Euler(mouseyAxis,0,mousexAxis);
			transform.rotation = Quaternion.Slerp(transform.rotation,target, Time.deltaTime + smooth);
		}
	}
}
