using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusCollected: MonoBehaviour {
	public AudioSource mmm;
	// Use this for initialization
	void Start () {
		mmm = GetComponent<AudioSource> ();
	}

	void OnTriggerEnter (Collider collider	)
	{
		if (collider.tag == "Player") 
		{
			mmm.Play ();

			Debug.Log ("Mmm");

		}
	}
}
