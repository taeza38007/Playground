using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public float speed;



	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		speed = 25.0f;

	}


	void FixedUpdate(){


		float moveLeft = Input.GetAxis ("Horizontal");
		float moveUp = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3(moveLeft,0.0f,moveUp);

		rb.AddForce (movement*speed);



	}

}
