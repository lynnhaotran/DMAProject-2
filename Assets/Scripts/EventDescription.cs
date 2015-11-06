using UnityEngine;
using System.Collections;

public class EventDescription : MonoBehaviour {

	public GUISkin customButton;
	public GameObject coworker;
	public GameObject coffee;
	Renderer showcoworker;
	BoxCollider2D talk;
	BoxCollider2D spill_coffee;
	int state = 0;  
	bool finished = false;

	// Use this for initialization
	void Start () {
		showcoworker = coworker.gameObject.GetComponent<Renderer> ();
		talk = coworker.gameObject.GetComponent<BoxCollider2D> ();
		spill_coffee = coffee.gameObject.GetComponent<BoxCollider2D> ();

		spill_coffee.enabled = false;
		
		if (VariableControl.Day == 3) {
			showcoworker.enabled = false;
			talk.enabled = false;
			spill_coffee.enabled = true;
		}
	}
	
	// Update is called once per frame
	void Update () {

		if (VariableControl.numFish == 15)
			state = 1;
		else if (VariableControl.coffeeSpilled)
			state = 2;
		else if (VariableControl.numChild >= 3)
			state = 3;


		if (VariableControl.numFish > 0 && VariableControl.numFish != 15)
			VariableControl.numFish = 0;
		if (VariableControl.numChild < 3)
			VariableControl.numChild = 0;

	}

	void OnGUI () {
		GUI.skin = customButton;

		if (state == 1 && !VariableControl.FishApp) {
			if (GUI.Button (new Rect (Screen.width / 4, Screen.height / 4, Screen.width / 2, Screen.height / 2), 
		                "Event!! \n Your app, Bouncy Fish, gets wildly popular overnight! " +
				"\n You merchandise all the extra fish you have at home for your game. " +
				"\n Success +15 \n (Click to Exit)")) {
				VariableControl.FishApp = true;
				VariableControl.Success += 15;
				state = 0;
			}
		}

		if (state == 2 && VariableControl.Day == 4) {
			if (GUI.Button (new Rect (Screen.width / 4, Screen.height / 4, Screen.width / 2, Screen.height / 2), 
		                "Event!! \n Because of the spill, Billy loses all his work. You console him. " +
				"\n On the other hand, you've been promoted for releasing Bouncy Fish!" +
				"\n Success +15, Jerk +15 \n (Click to Exit)")) {
				if (VariableControl.coffeeSpilled) {
					VariableControl.coffeeSpilled = false;
					VariableControl.Jerk += 15;
					VariableControl.Success += 15;

					if (VariableControl.numChild > 3)
						state = 3;
					else
						state = 0;
				}
			}
		}

		if (state == 3) {
			if (GUI.Button (new Rect (Screen.width / 4, Screen.height / 4, Screen.width / 2, Screen.height / 2), 
			                "Event!! \n Someone videotaped you kicking balls at kids! " +
				"\n That's definitely not good for your rep..." +
				"\n Success -10 \n (Click to Exit)")) {
				if (!finished) {
					VariableControl.Success -= 10;
					VariableControl.numChild = 0;

					if (VariableControl.Success <= 0)
						VariableControl.Success = 0;

					state = 0;
				}


			}
		}
	}
	
}
