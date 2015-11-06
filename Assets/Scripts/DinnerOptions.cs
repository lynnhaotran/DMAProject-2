using UnityEngine;
using System.Collections;

public class DinnerOptions : MonoBehaviour {

	public GameObject Player;
	public GameObject Player_sitting;
	Renderer sit;
	int stateOfDialogue = -1;
	Quaternion rotate = Quaternion.identity;
	bool finished = false;

	public GUIStyle buttons;
	public GUISkin customButton;

	// Use this for initialization
	void Start () {
		sit = Player_sitting.gameObject.GetComponent<Renderer> ();
		sit.enabled = false;
		VariableControl.Wealth -= 10;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space) && stateOfDialogue == 0) {
			stateOfDialogue = 1;
			sit.enabled = true;
		}

		if (VariableControl.Success >= 100) {
			Application.LoadLevel("End");
		}
	}

	void OnTriggerEnter2D (Collider2D other) {
		stateOfDialogue = 0;
		if (stateOfDialogue == 1) 
			Destroy (other.gameObject);
	}

	void OnTriggerExit2D (Collider2D other) {
		stateOfDialogue = -1;
	}

	void OnGUI () {

		string[] text = {
			"Hey, it's good to see you again!",
			"Thanks for waiting, you look great.",
			"Sorry I'm a bit late.",
			"Yeah, good thing I made it. Backed up at work.",
			"No worries, it wasn't long. Have you been to this restaurant before?",
			"Oh no, just used my Yelp-fu to find it.",
			"No, but it was recommended on Yelp.",
			"Nah, just a random pick on Yelp.",
			"Ah, I see. What kind of food do you usually eat?",
			"Hmm, however much I can pay? (haha)",
			"Whatever will look good on my Instagram. (haha)",
			"Oh you know, however much I can pay. (smirk)",
			"Hahaha...(silence). Um, do you know what you'll order?",
			"The more expensive, the better, right?",
			"I heard gluten-free is the way to go.",
			"Whatever's Instagrammable, of course.",
			"Oh, are you gluten-intolerant?",
			"Nah, it just seems in ATM.",
			"LOL no, is anyone really?",
			"Does this face look gluten-intolerant to you?",
			"OMG me too! I LOVE Instagram.",
			"I mean...if you've got the money. *shrug*",
			"In?? Seriously?? I'm gluten-intolerant, you obnoxious twat!",
			"Yeah, it's a pretty lame fad at the moment...",
			"Um..."
		};

		GUI.skin = customButton;

		if (stateOfDialogue == 0) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), "Hit 'Space' to greet your date", 24, Color.black, "BernerBasisschrift1");
		}

		if (stateOfDialogue == 1) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[0], 20, Color.black, "BernerBasisschrift1");
			if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 8, 300, 75), text[1])) {
				stateOfDialogue = 2;
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 500, Screen.height / 8, 300, 75), text[2])) {
				stateOfDialogue = 2;
			}
			if (GUI.Button (new Rect (Screen.width / 2 + 200, Screen.height / 8, 300, 75), text[3])) {
				stateOfDialogue = 2;
			}
		}

		if (stateOfDialogue == 2) {

			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[4], 20, Color.black, "BernerBasisschrift1");
			if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 8, 300, 75), text[5])) {
				stateOfDialogue = 3;
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 500, Screen.height / 8, 300, 75), text[6])) {
				stateOfDialogue = 3;
			}
			if (GUI.Button (new Rect (Screen.width / 2 + 200, Screen.height / 8, 300, 75), text[7])) {
				stateOfDialogue = 3;
			}
		}

		if (stateOfDialogue == 3) {
			
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[8], 20, Color.black, "BernerBasisschrift1");
			if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 8, 300, 75), text[9])) {
				stateOfDialogue = 5;
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 500, Screen.height / 8, 300, 75), text[10])) {
				stateOfDialogue = 4;
			}
			if (GUI.Button (new Rect (Screen.width / 2 + 200, Screen.height / 8, 300, 75), text[11])) {
				stateOfDialogue = 5;
			}
		}

		if (stateOfDialogue == 4) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[20], 20, Color.black, "BernerBasisschrift1");
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 60), ("You hit it off well with your date the rest of then night. Success +10"), 20, Color.black, "BernerBasisschrift1");
			if (!finished) {
				finished = true;
				VariableControl.Success += 10;
				VariableControl.Day += 1;
			}
			Invoke ("goToOffice", 5);
		}

		if (stateOfDialogue == 5) {
			
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[12], 20, Color.black, "BernerBasisschrift1");
			if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 8, 300, 75), text[13])) {
				stateOfDialogue = 6;
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 500, Screen.height / 8, 300, 75), text[14])) {
				stateOfDialogue = 7;
			}
			if (GUI.Button (new Rect (Screen.width / 2 + 200, Screen.height / 8, 300, 75), text[15])) {
				stateOfDialogue = 4;
			}
		}

		if (stateOfDialogue == 6) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[21], 20, Color.black, "BernerBasisschrift1");
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 60), ("Your date seems indifferent. You guys don't really hit it off."), 20, Color.black, "BernerBasisschrift1");
			if (!finished) {
				finished = true;
				VariableControl.Day += 1;
			}
			Invoke ("goToOffice", 5);
		}

		if (stateOfDialogue == 7) {
			
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[16], 20, Color.black, "BernerBasisschrift1");
			if (GUI.Button (new Rect (Screen.width / 2 - 150, Screen.height / 8, 300, 75), text[17])) {
				stateOfDialogue = 8;
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 500, Screen.height / 8, 300, 75), text[18])) {
				stateOfDialogue = 9;
			}
			if (GUI.Button (new Rect (Screen.width / 2 + 200, Screen.height / 8, 300, 75), text[19])) {
				stateOfDialogue = 10;
			}
		}

		if (stateOfDialogue == 8) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[22], 20, Color.black, "BernerBasisschrift1");
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 60), ("Your date storms off. *shrug* Whatever. Jerk +10, Success -10"), 20, Color.black, "BernerBasisschrift1");
			if (!finished) {
				finished = true;
				VariableControl.Jerk += 10;
				VariableControl.Success -= 10;
				VariableControl.Day += 1;
			}
			Invoke ("goToOffice", 5);
		}

		if (stateOfDialogue == 9) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[23], 20, Color.black, "BernerBasisschrift1");
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 60), ("The date ends a little cold. Probably not gonna follow up with her. Jerk +5, Success -5"), 20, Color.black, "BernerBasisschrift1");
			if (!finished) {
				finished = true;
				VariableControl.Jerk += 5;
				VariableControl.Success -= 5;
				VariableControl.Day += 1;
			}
			Invoke ("goToOffice", 5);
		}

		if (stateOfDialogue == 10) {
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), text[24], 20, Color.black, "BernerBasisschrift1");
			AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 60), ("Your date seems off-put. Who would be off-put by this face? Whatever. Jerk +2"), 20, Color.black, "BernerBasisschrift1");
			if (!finished) {
				finished = true;
				VariableControl.Jerk += 2;
				VariableControl.Day += 1;
			}
			Invoke ("goToOffice", 5);
		}
	}

	void goToOffice() {
		if (VariableControl.Success <= 0)
			VariableControl.Success = 0;
		Application.LoadLevel ("Office");
	}
}
