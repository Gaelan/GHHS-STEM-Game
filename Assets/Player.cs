
using UnityEngine;

using System.Collections;



[RequireComponent (typeof (PlayerController))]

[RequireComponent (typeof (GunController))]

public class Player : LivingEntity {


	//private bool Dir = true ;
	public float moveSpeed = 5;



	Camera viewCamera;

	PlayerController controller;

	GunController gunController;



	protected override void Start () {

		base.Start ();

		controller = GetComponent<PlayerController> ();

		gunController = GetComponent<GunController> ();

		viewCamera = Camera.main;

	}



	void fixedUpdate () {

		// Movement input

		Vector3 moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		Vector3 moveVelocity = moveInput.normalized * moveSpeed;
		controller.Move (moveVelocity);
		//if (Input.GetAxisRaw ("Vertical") < 0) {
			//transform.localScale += new Vector3(0.1F, 0, 0);
		//} 



		// Look input

		//	Ray ray = viewCamera.ScreenPointToRay (Input.mousePosition);

	//		Plane groundPlane = new Plane (Vector3.up, Vector3.zero);

	//		float rayDistance;



	//		if (groundPlane.Raycast(ray,out rayDistance)) {

	//		Vector3 point = ray.GetPoint(rayDistance);

			//Debug.DrawLine(ray.origin,point,Color.red);

	//		controller.LookAt(point);

	//	}



		// Weapon input

		if (Input.GetMouseButton(0)) {

			gunController.Shoot();

		}

	}

}