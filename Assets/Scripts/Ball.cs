using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	
	float ballLife = 10.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		ballLife -= Time.deltaTime;

		if (ballLife <= 0)
			Destroy (this.gameObject);
	}
	

	void OnCollisionEnter2D (Collision2D coll) {
		if (coll.gameObject.GetComponent<PlayerMove4>() != null) {
			this.GetComponent<Rigidbody2D>().velocity = this.transform.forward * 3;
		}

		if (coll.gameObject.GetComponent<SmallChild> () != null) {
			VariableControl.Jerk += 5;
			VariableControl.Success += 5;
			VariableControl.numChild += 1;
			Destroy(coll.gameObject);
			Destroy (this.gameObject);
		}

		if (coll.gameObject.name == "Goal") {
			VariableControl.Success += 2;
			Destroy(this.gameObject);
		}
	}
}
