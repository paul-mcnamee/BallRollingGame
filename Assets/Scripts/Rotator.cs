using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	public int speed = 20;

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	private float speedTranslationX;
	private float speedTranslationY;
	private float speedTranslationZ;
	
	

	void Update()
	{
		speedTranslationX = speed * (Random.Range(-1, 1));
		speedTranslationZ = speed * (Random.Range(-1, 1));

		Vector3 movement = new Vector3 (speedTranslationX, 0.0f, speedTranslationZ);

		rb.AddForce (movement * speed);

		
	}
}

