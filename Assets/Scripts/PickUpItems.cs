using UnityEngine;
using System.Collections;

public class PickUpItems : MonoBehaviour {

	public string message;
	public float w_points;
	public float j_points;
	public float s_points;
	
	bool displayMessage = false;
	bool cannotAfford = false;

	void Update () {

		if (Input.GetKeyDown (KeyCode.Space) && displayMessage) {
			if (Mathf.Abs(w_points) > VariableControl.Wealth)
				cannotAfford = true;
			else {
				VariableControl.Jerk += j_points;
				VariableControl.Success += s_points;
				VariableControl.Wealth += w_points;
				displayMessage = false;
				Destroy (this.gameObject);
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.GetComponent<PlayerMove4> () != null)
			displayMessage = true;
	}

	void OnTriggerExit2D (Collider2D other) {
		displayMessage = false;
		cannotAfford = false;
	}
	
	void OnGUI() {
		if (displayMessage && !cannotAfford) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), message, 24, Color.black, "BernerBasisschrift1");
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 70), "Press 'Space' to purchase", 24, Color.black, "BernerBasisschrift1");
		}

		if (cannotAfford) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), "Weird, I don't have enough money right now.", 24, Color.black, "BernerBasisschrift1");
		}
	}

}
