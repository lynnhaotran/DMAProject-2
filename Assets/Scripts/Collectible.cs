using UnityEngine;
using System.Collections;

public class Collectible : MonoBehaviour {

	int currentState = 0;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) && currentState == 1) {
			VariableControl.Wealth += 10;
			VariableControl.Success += 1;
			Destroy (this.gameObject);
		}
	}

	//Adapted from DestroyOnTrigger.cs
	void OnTriggerEnter2D (Collider2D other) 
	{
		//Prompt the user 
		if (other.gameObject.GetComponent<PlayerMove4> () != null)
			currentState = 1;
		
	}

	void OnGUI () {

		if (currentState == 1)
			AlexUtil.DrawText(new Vector2(20,20), "Hit 'Space' to pick up item", 24, Color.black, "BernerBasisschrift1");
	}

}
