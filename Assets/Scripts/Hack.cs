using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Hack : MonoBehaviour {

	public float time = 0.0f;
	public static int amountEarned = 0;
	int numberOfHacks = 0;
	int random;
	float changetext;
	float typingDissapearTime;
	bool functionCalled = false;
	bool hkey = false;
	bool akey = false;
	bool ckey = false;
	bool hack = false;
	
	List<char> keyboardInput = new List<char>();

	void Start() {
		changetext = 0.0f;
	}

	void Update() {
		print (VariableControl.Wealth);
		time += Time.deltaTime;
		changetext += Time.deltaTime;

		if (time > 10 && (!functionCalled)) {
			functionCalled = true;
			Invoke ("countHacks", 0);
			Invoke ("goToActivities", 3);
		}

		if (Input.GetKey(KeyCode.H) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.C) || Input.GetKey(KeyCode.K)) {
			if (changetext > 0.15f) {
				changetext = 0.0f;
				random = Random.Range (0,7);
			}
			typingDisappear();
		}

		foreach (char c in Input.inputString) {
			keyboardInput.Add (c);
		}

	}

	void countHacks () {
		for (int i = 0; i != keyboardInput.Count; i++) {

			if (hack) {
				numberOfHacks += 1;
				hkey = false;
				akey = false;
				ckey= false;
				hack = false;
			}

			if (keyboardInput[i] == 'h') {
				hkey = true;
				continue;
			}

			if (hkey && (!akey)) {
				if (keyboardInput[i] == 'a') 
					akey = true;
				else 
					hkey = false;	
				continue;
			}

			if (hkey && akey && (!ckey)) {
				if (keyboardInput[i] == 'c') 
					ckey = true;
				else {
					hkey = false;
					akey = false;
				}
				continue;
			}

			if (hkey && akey && ckey) {
				if (keyboardInput[i] == 'k') 
					hack = true;
				else {
					hkey = false;
					akey = false;
					ckey = false;
				}
				continue;
			}

		}
		if (hack)
			numberOfHacks += 1;

		amountEarned = numberOfHacks * 10;
		VariableControl.Wealth += numberOfHacks;

		if (VariableControl.Wealth >= 100)
			VariableControl.Wealth = 100;

		numberOfHacks = 0;
	}

	void typingDisappear () {
		typingDissapearTime = Time.time + 3;
	}

	void goToActivities () {
		Application.LoadLevel ("Activities");
	}

	void OnGUI () {

		//Thanks for the tips Alex! :D

		AlexUtil.DrawCenteredText(new Vector2(0, -Screen.height/2 + 40), "Repeatedly type 'hack' to work", 24, Color.black, "BernerBasisschrift1");

		//show text if it has not yet reached disappear time
		bool typing = Time.time < typingDissapearTime;

		if (typing) {

			//text positions
			Vector2[] positionOffsets = {
				new Vector2(-430,-50),
				new Vector2(-480,-40),
				new Vector2(380,-70),
				new Vector2(340,-75),
				new Vector2(400,-40),
				new Vector2(-380,-50),
				new Vector2(-440,-30),
				new Vector2(300,-80),
			};

			int[] fontSizes = { 16, 24, 36, 48, 60, 72, 84, 90 }; 

			//randomly grab positions + fontsizes
			AlexUtil.DrawText (new Vector2 ((Screen.width / 2), Screen.height/2) + positionOffsets[random], 
			                   "hack", fontSizes[random], Color.black, "BernerBasisschrift1");	
		}
	}
	
}
