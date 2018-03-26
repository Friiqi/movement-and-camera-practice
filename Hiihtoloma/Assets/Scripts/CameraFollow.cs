﻿using UnityEngine;
using System.Collections;


public class CameraFollow : MonoBehaviour {

	private const float Y_ANGLE_MIN = 0.0f;
	private const float Y_ANGLE_MAX = 50.0f;
	public Transform lookAt;
	public Transform camTransform;
	public Vector3 offset;
	public float smoothSpeed = 10f;

	private Camera cam; 
	private float distance = 5.0f;
	private float currentX = 0.0f;
	private float currentY = 0.0f;
	private float sensitivityX = 7.0f;
	private float sensitivityY = 1.0f;

	private void Start()
	{
		camTransform = transform;
		cam = Camera.main;


	}
	private void Update()
	{
		if (Input.GetMouseButton (1)) {
			currentX += Input.GetAxis ("Mouse X");
			currentY += Input.GetAxis ("Mouse Y");
			currentY = Mathf.Clamp (currentY, Y_ANGLE_MIN, Y_ANGLE_MAX);

		}
	}


	private void LateUpdate()
	{
		if (Input.GetMouseButton (1)) {
			Vector3 dir = new Vector3 (0, 0, -distance);
			Quaternion rotation = Quaternion.Euler (currentY, currentX, 0);
			camTransform.position = lookAt.position + rotation * dir;
			camTransform.LookAt (lookAt.position); 
				
		
		}

	}
	}
