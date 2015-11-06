using UnityEngine;
using System.Collections;

public class WorkTransition : MonoBehaviour {

	int currentState = 0;

	void Update () {
		if (Input.GetKeyDown (KeyCode.Space) && currentState == 1) {
			//print("Going to work!");
			Invoke ("goToWork", 0);
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		currentState = 1;
	}

	void OnTriggerExit2D (Collider2D other) {
		currentState = 0;
	}

	void goToWork () {
		Application.LoadLevel ("Work");
	}

	void OnGUI () {
		if (currentState == 1)
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), "Hit 'Space' to start working", 24, Color.black, "BernerBasisschrift1");
	}
}
