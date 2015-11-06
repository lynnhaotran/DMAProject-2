using UnityEngine;
using System.Collections;

public class ToEnd : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Space)) 
			Application.LoadLevel ("Start");
	}

	void OnGUI () {
		AlexUtil.DrawCenteredText(new Vector2(0,-Screen.height/2 + 40), "Wow, you're super successful! Let's look at your stats...", 48, Color.black, "BernerBasisschrift1");
		AlexUtil.DrawCenteredText(new Vector2(0,-Screen.height/2 + 100), "It took you " + VariableControl.Day + " days to become successful, " +
		                          "you still have $" + VariableControl.Wealth + "k, and on a scale of 1-100, your Jerk level is " + VariableControl.Jerk, 32, Color.black, "BernerBasisschrift1");

		string[] outcomes = {
			"Um...you aren't really cut out for the tech life. You're a bit of a pushover...",
			"You're an overachiever, but definitely working too hard and spending too much. You could stand to be meaner...",
			"Ouch. In the end you were successful, but being a Jerk really cost you...be a little more discreet next time.",
			"You're loaded! But definitely working too hard. There are easier ways to success...",
			"You're a bright and emerging star in the tech industry. Your name is definitely out there! But you're kind of a jerk.",
			"Congrats! You've become the CEO of a huge company called Ahpel! You're infamous, and loaded $$$",
			"You're an average worker, but a little over your head. Stop spending so much!",
			"Hmm...being a jerk really hindered your success. But it's the key to success! Be more careful next time.",
			"You're a 'slow and steady wins the race' kind of guy. But that's not the tech industry. Get aggressive!",
			"Nice! You're doing pretty well, but not as quick as that guy who founded Gugel.",
			"It took you a while, but you're infamous for your mad programming skills and ruthlessness. Maybe you can be a CEO someday.",
			"If I were you, I'd work on your speed.",
			"If I were you, I'd work on your meanness.",
			"If I were you, I'd work on your savings."
		};

		if (VariableControl.Day <= 10) {
			if (VariableControl.Wealth < 50 && VariableControl.Jerk < 50) {
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[1], 32, Color.black, "BernerBasisschrift1");
				AlexUtil.DrawCenteredText(new Vector2(0, 40), outcomes[12], 32, Color.black, "BernerBasisschrift1");
			}

			if (VariableControl.Wealth < 50 && VariableControl.Jerk > 50) {
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[2], 32, Color.black, "BernerBasisschrift1");
				AlexUtil.DrawCenteredText(new Vector2(0, 40), outcomes[13], 32, Color.black, "BernerBasisschrift1");
			}

			if (VariableControl.Wealth > 50 && VariableControl.Jerk < 50) {
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[3], 32, Color.black, "BernerBasisschrift1");
				AlexUtil.DrawCenteredText(new Vector2(0, 40), outcomes[12], 32, Color.black, "BernerBasisschrift1");
			}

			if (VariableControl.Wealth > 50 && VariableControl.Jerk > 50 && VariableControl.Jerk < 100) {
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[4], 32, Color.black, "BernerBasisschrift1");
				AlexUtil.DrawCenteredText(new Vector2(0, 40), outcomes[12], 32, Color.black, "BernerBasisschrift1");
			}

			if (VariableControl.Wealth > 50 && VariableControl.Jerk >= 100)
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[5], 32, Color.black, "BernerBasisschrift1");
		}

		if (VariableControl.Day > 10 && VariableControl.Day <= 20) {
			if (VariableControl.Wealth < 50 && VariableControl.Jerk < 50) {
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[6], 32, Color.black, "BernerBasisschrift1");
				AlexUtil.DrawCenteredText(new Vector2(0, 40), outcomes[11], 32, Color.black, "BernerBasisschrift1");
			}
			
			if (VariableControl.Wealth < 50 && VariableControl.Jerk > 50) {
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[7], 32, Color.black, "BernerBasisschrift1");
				AlexUtil.DrawCenteredText(new Vector2(0, 40), outcomes[11], 32, Color.black, "BernerBasisschrift1");
			}
			
			if (VariableControl.Wealth > 50 && VariableControl.Jerk < 50) {
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[8], 32, Color.black, "BernerBasisschrift1");
				AlexUtil.DrawCenteredText(new Vector2(0, 40), outcomes[11], 32, Color.black, "BernerBasisschrift1");
			}
			
			if (VariableControl.Wealth > 50 && VariableControl.Jerk > 50 && VariableControl.Jerk < 100) {
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[9], 32, Color.black, "BernerBasisschrift1");
				AlexUtil.DrawCenteredText(new Vector2(0, 40), outcomes[11], 32, Color.black, "BernerBasisschrift1");
			}

			if (VariableControl.Wealth > 50 && VariableControl.Jerk >= 100) {
				AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[10], 32, Color.black, "BernerBasisschrift1");
				AlexUtil.DrawCenteredText(new Vector2(0, 40), outcomes[11], 32, Color.black, "BernerBasisschrift1");
			}
		}

		if (VariableControl.Day > 20 && VariableControl.Day <= 30) 
			AlexUtil.DrawCenteredText(new Vector2(0, 0), outcomes[0], 32, Color.black, "BernerBasisschrift1");

		AlexUtil.DrawCenteredText(new Vector2(0, Screen.height/2 - 80), "Press 'space' to try again!", 32, Color.black, "BernerBasisschrift1");

	}
}
