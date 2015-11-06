using UnityEngine;
using System.Collections;

public class VariableControl : MonoBehaviour {

	public static float Wealth;
	public static float Jerk;
	public static float Success;
	public static int Day;

	public static bool FishApp;
	public static int numFish;
	public static bool coffeeSpilled = false;
	public static int numChild;


	// Use this for initialization
	void Start () {
		Wealth = 0;
		Jerk = 0;
		Success = 0;
		Day = 1;
		FishApp = false;
		numFish = 0;
		numChild = 0;
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			Application.LoadLevel ("Office");
		}

	}

	void OnGUI () {
		AlexUtil.DrawCenteredText(new Vector2(0,-55), "Tech Tycoon!", 84, Color.black, "BernerBasisschrift1");
		AlexUtil.DrawCenteredText(new Vector2(0,0), "Hit 'Space' to start playing", 36, Color.black, "BernerBasisschrift1");

	}
}
