using UnityEngine;
using System.Collections;

public class PickUpFish : MonoBehaviour {

	public string message;
	
	bool displayMessage = false;
	
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Space) && displayMessage) {
				displayMessage = false;
				VariableControl.numFish += 1;
				Destroy (this.gameObject);
		}
	}
	
	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.GetComponent<PlayerMove4> () != null)
			displayMessage = true;
	}
	
	void OnTriggerExit2D (Collider2D other) {
		displayMessage = false;
	}
	
	void OnGUI() {
		if (displayMessage) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), message, 24, Color.black, "BernerBasisschrift1");
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 70), "Press 'Space' to purchase", 24, Color.black, "BernerBasisschrift1");
		}

	}
}
