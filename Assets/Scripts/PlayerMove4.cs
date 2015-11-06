using UnityEngine;
using System.Collections;

//Adapted from the following tutorial:
//unity3d.com/learn/tutorials/modules/beginner/2d/2d-controllers

public class PlayerMove4 : MonoBehaviour {

	float maxSpeed = 6.0f;
	bool facingRight = false;
	//Animator animate;

	// Use this for initialization
	void Start () {
		//animate = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float move_x = Input.GetAxis ("Horizontal");
		float move_y = Input.GetAxis ("Vertical");
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (move_x * maxSpeed, 
		                                                         move_y * maxSpeed);
		//animate.SetFloat ("Speed", Mathf.Abs (move_x));

		if (move_x > 0 && !facingRight) 
			FlipCharacter ();
		else if (move_x < 0 && facingRight)
			FlipCharacter ();
	}

	void FlipCharacter() {
		facingRight = !facingRight;
		Vector3 scale = this.transform.localScale;
		scale.x *= -1;
		this.transform.localScale = scale;
	}
}
