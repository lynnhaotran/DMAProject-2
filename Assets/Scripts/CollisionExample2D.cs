using UnityEngine;
using System.Collections;

public class CollisionExample2D : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D coll) {
		print("rainbow enters collision with " + coll.gameObject.name);
	}

	void OnCollisionExit2D(Collision2D coll) {
		print("rainbow leaves collision with " + coll.gameObject.name);
	}

	void OnCollisionStay2D(Collision2D coll) {
		print("rainbow collides with " + coll.gameObject.name);
	}

	/////////

	void OnTriggerEnter2D(Collider2D coll) {
		print("rainbow enters trigger with " + coll.gameObject.name);
	}
	
	void OnTriggerExit2D(Collider2D coll) {
		print("rainbow leaves trigger with " + coll.gameObject.name);
	}
	
	void OnTriggerStay2D(Collider2D coll) {
		print("rainbow triggers with " + coll.gameObject.name);
	}


}
