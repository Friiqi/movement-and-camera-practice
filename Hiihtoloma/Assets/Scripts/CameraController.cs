using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform target;
	public float smoothSpeed = 10f;
	public Vector3 offset;

	public float rotateSpeed;
	void FixedUpdate ()
	{

		float horizontal = Input.GetAxis ("Mouse X") * rotateSpeed;
		if (Input.GetMouseButtonDown (1)) 
		{
			target.Rotate (0, horizontal, 0);

			float desiredXAngle = target.eulerAngles.x;
			Quaternion rotation = Quaternion.Euler (0,desiredXAngle, 0);
			transform.position = target.position - (rotation * offset);
		}
		transform.LookAt (target);
	}

	/*
	public void HandleMouseRotation()
	{
		var easeFactor = 10f;
		if (Input.GetMouseButton (1)) 
		{
			if (Input.mousePosition.x != mouseX) 
			{
				var cameraRotationY = (Input.mousePosition.x - mouseX) * easeFactor * Time.deltaTime;
				this.transform.Rotate(0,cameraRotationY,0);
			}
		}
	}
	*/
}
