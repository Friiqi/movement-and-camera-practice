using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyable : MonoBehaviour {

	void OnTriggerEnter (Collider collider	)
	{
		if (collider.tag == "Weapon") 
		{
			Destroy (gameObject);
		}
	}
}
