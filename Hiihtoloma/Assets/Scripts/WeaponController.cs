using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();

	}
	void Update ()
	{
		if (Input.GetMouseButtonDown (0)) 
		{
			animator.SetTrigger ("Base_Attack");
				
		}
	}



}
