using UnityEngine;
using System.Collections;

public class Animatro : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.W)) {
			anim.SetInteger ("State", 1);
		} else if (Input.GetKeyUp (KeyCode.W)) {
			anim.SetInteger ("State", 0);
		} else if (Input.GetKeyDown (KeyCode.S)) {
			anim.SetInteger ("State", 3);
		} else if (Input.GetKeyUp (KeyCode.S)) {
			anim.SetInteger ("State", 0);
		} else if (Input.GetKeyDown (KeyCode.D)) {
			anim.SetInteger ("State", 2);
		} else if (Input.GetKeyUp (KeyCode.D)) {
			anim.SetInteger ("State", 0);
		} else if (Input.GetKeyDown (KeyCode.A)) {
			anim.SetInteger ("State", 4);
		} else if (Input.GetKeyUp (KeyCode.A)) {
			anim.SetInteger ("State", 0);
		}
	}
}
