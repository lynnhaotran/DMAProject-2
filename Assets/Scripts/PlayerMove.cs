using UnityEngine;
using System.Collections;

//Adapted from the following tutorial:
//unity3d.com/learn/tutorials/modules/beginner/2d/2d-controllers

public class PlayerMove : MonoBehaviour {

	public GameObject player;
	float maxSpeed = 5.0f;
	bool facingRight = false;
	bool dinner = false;
	Vector3 leftSide;
	Vector3 rightSide;
	//Animator animate;

	// Use this for initialization
	void Start () {
		/*animate = this.GetComponent<Animator> ();
		leftSide = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, 0));
		rightSide = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, 0));*/
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && dinner) 
			Destroy (this.gameObject);
	}

	// Update is called once per frame
	void FixedUpdate () {
		float move = Input.GetAxis ("Horizontal");
		this.GetComponent<Rigidbody2D>().velocity = new Vector2 (move * maxSpeed, 
		                                                         this.GetComponent<Rigidbody2D>().velocity.y);
		//animate.SetFloat ("Speed", Mathf.Abs (move));

		if (move > 0 && !facingRight) 
			FlipCharacter ();
		else if (move < 0 && facingRight)
			FlipCharacter ();

		/*if (this.gameObject.transform.position.x >= rightSide.x) {
			Instantiate(player, new Vector3 (leftSide.x, this.gameObject.transform.position.y, 0), Quaternion.identity);
			Destroy(this.gameObject);
		}*/
	}

	void FlipCharacter() {
		facingRight = !facingRight;
		Vector3 scale = this.transform.localScale;
		scale.x *= -1;
		this.transform.localScale = scale;
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.GetComponent<DinnerOptions> () != null) 
			dinner = true;
	}

}
