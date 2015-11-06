using UnityEngine;
using System.Collections;

public class SwitchScene : MonoBehaviour {
	
	public float timer;

	// Use this for initialization
	void Start () {
		timer = 45.0f;
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime; 

		if (VariableControl.Success >= 100) {
			Application.LoadLevel("End");
		}
		
		if (timer <= 0.0f) {
			VariableControl.Day += 1;
			Application.LoadLevel("Office");
		}
	}

	void OnGUI () {
		AlexUtil.DrawText(new Vector2(Screen.width - 150, 45), "Time: " + timer.ToString("0"), 36, Color.black, "BernerBasisschrift1");
	}
}
