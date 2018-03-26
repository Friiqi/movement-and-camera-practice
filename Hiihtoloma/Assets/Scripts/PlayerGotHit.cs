using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGotHit : MonoBehaviour {
	public AudioSource aii;
	// Use this for initialization
	void Start () {
		aii = GetComponent<AudioSource> ();
	}
	
	void OnTriggerEnter (Collider collider	)
	{
		if (collider.tag == "Player") 
		{
			aii.Play ();

			Debug.Log ("Aii");

		}
	}
}
