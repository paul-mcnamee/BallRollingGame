using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		float jump = Input.GetKey("space") ? 5 : 0;

		Vector3 movement = new Vector3 (moveHorizontal, jump, moveVertical);

		rb.AddForce (movement * speed);
	}

    void OnCollisionEnter(Collision collision) 
	{
		if (collision.gameObject.CompareTag("Pick Up"))
		{
			// Move the blocks
			collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.collider.GetComponent<Rigidbody>().velocity * collision.collider.GetComponent<Rigidbody>().velocity.magnitude * speed);
			
		}
    }

}
