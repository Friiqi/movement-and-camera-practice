using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
	
	public float MovementSpeed,rotationSpeed;
	Rigidbody playerRigidBody;


	void Start () {
		
		playerRigidBody = GetComponent <Rigidbody> ();


	}
	
	// Update is called once per frame
	void Update () {
		
		//transform.Translate(MovementSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,MovementSpeed*Input.GetAxis("Jump")*Time.deltaTime,MovementSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
		Vector3 movement = new Vector3 (MovementSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,MovementSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
		playerRigidBody.MovePosition (transform.position + movement);

		if (Input.GetMouseButton (1)) 
		{
			transform.Rotate (new Vector3(0, Input.GetAxis ("Mouse X"), 0)*Time.deltaTime*rotationSpeed);
		}

	}
	void OnTriggerEnter (Collider collider	)
	{
		if (collider.tag == "Dangerous") 
		{
			
			gameObject.SetActive (false);
			Debug.Log ("Pelaaja kuoli");

		}
	}

}


