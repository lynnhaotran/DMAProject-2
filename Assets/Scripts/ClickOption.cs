using UnityEngine;
using System.Collections;

public class ClickOption : MonoBehaviour {

	public GameObject shopping_instructions;
	public GameObject dinner_instructions;
	public GameObject sports_instructions;
	Renderer shopping;
	Renderer dinner;
	Renderer sports;

	void Start () {
		shopping = shopping_instructions.gameObject.GetComponent<Renderer> ();
		dinner = dinner_instructions.gameObject.GetComponent<Renderer> ();
		sports = sports_instructions.gameObject.GetComponent<Renderer> ();
		shopping.enabled = false;
		dinner.enabled = false;
		sports.enabled = false;
	}

	void OnMouseDown () {
		if (this.gameObject.name == "sports_option") 
			Application.LoadLevel ("Sports");
		if (this.gameObject.name == "shopping_option") {

			int isItFishShopping = Random.Range(0, 2);
			
			if (VariableControl.Day == 3)
				Invoke ("goShopping", 0);
			else if (isItFishShopping == 0 && (!VariableControl.FishApp))
				Invoke ("fishShopping", 0);
			else
				Invoke ("goShopping", 0);

		}
		if (this.gameObject.name == "dinner_option")
			Application.LoadLevel ("Dinner");
	}

	void OnMouseOver () {
		if (this.gameObject.name == "sports_option") 
			sports.enabled = true;
		if (this.gameObject.name == "shopping_option")
			shopping.enabled = true;
		if (this.gameObject.name == "dinner_option")
			dinner.enabled = true;
	}

	void OnMouseExit() {
		if (this.gameObject.name == "sports_option") 
			sports.enabled = false;
		if (this.gameObject.name == "shopping_option")
			shopping.enabled = false;
		if (this.gameObject.name == "dinner_option")
			dinner.enabled = false;
	}

	void OnGUI () {
		AlexUtil.DrawCenteredText (new Vector2 (0, -(Screen.height*0.4f)), "Hooray! You earned $" + (Hack.amountEarned) + " dollars today. " +
			"What would you like to do now?", 24, Color.black, "BernerBasisschrift1");
	}

	void fishShopping () {
		Application.LoadLevel ("Fish Shopping");
	}

	void goShopping() {
		Application.LoadLevel ("Shopping");
	}

}
