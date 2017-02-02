
using UnityEngine;

using System.Collections;



[RequireComponent (typeof (Rigidbody))]

public class PlayerController : MonoBehaviour {



	Vector2 velocity;

	Rigidbody2D myRigidbody;



	void Start () {

		myRigidbody = GetComponent<Rigidbody2D> ();

	}



	public void Move(Vector2 _velocity) {

		velocity = _velocity;

	}



	public void LookAt(Vector2 lookPoint) {
		transform.LookAt (lookPoint);

	}



	void FixedUpdate() {

		myRigidbody.MovePosition (myRigidbody.position + velocity * Time.fixedDeltaTime);



	}

}