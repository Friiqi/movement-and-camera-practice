using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class YouDied : MonoBehaviour {
	public Text youDied;
	void Start()
	{
		youDied.text = "";
	}
	void OnTriggerEnter (Collider collider	)
	{
		if (collider.tag == "Player") 
		{
			
			youDied.text = "You died!";

		}
	}
}
