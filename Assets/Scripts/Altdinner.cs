using UnityEngine;
using System.Collections;

public class Altdinner : MonoBehaviour {

	bool displayMessage;
	int state = 0;
	bool finished = false;
	public bool female;
	public string message;
	public string result;
	public float success;
	public float jerk;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (displayMessage && Input.GetKey (KeyCode.Space)) {
			if(this.gameObject.name == "Coworker Desk")
				VariableControl.coffeeSpilled = true;
			if (!finished) {
				finished = true;
				displayMessage = false;
				state = 1;
				VariableControl.Success += success;

				if (VariableControl.Success <= 0)
					VariableControl.Success = 0;

				VariableControl.Jerk += jerk;
				if (female) {
					VariableControl.Day += 1;
					Invoke ("goToWork", 5);
				}
			}
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		if (other.gameObject.GetComponent<PlayerMove> () != null && state == 0)
			displayMessage = true;
	}
	
	void OnTriggerExit2D (Collider2D other) {
		displayMessage = false;
		if (finished)
			state = 3;
	}

	void OnGUI () {
		if (displayMessage) 
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), message, 24, Color.black, "BernerBasisschrift1");
		

		if (state == 1)
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), result, 24, Color.black, "BernerBasisschrift1");

	}

	void goToWork () {
		Application.LoadLevel ("Office");
	}

}
