using UnityEngine;
using System.Collections;

//Display of progress bars adapted from Unity Answers.
//http://answers.unity3d.com/questions/11892/how-would-you-make-an-energy-bar-loading-progress.html

public class DisplayScore : MonoBehaviour {

	public float display;
	Vector2 position = new Vector2(60, 20);
	Vector2 size = new Vector2 (100, 20);
	public Texture2D emptybar;
	public Texture2D fullbar;
	public GUISkin customBox;
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		//display = (VariableControl.Wealth / 100);
	}

	void OnGUI () {
		AlexUtil.DrawText(new Vector2(20, 20), "Wealth ", 24, Color.black, "BernerBasisschrift1");
		AlexUtil.DrawText(new Vector2(45, 40), "Jerk ", 24, Color.black, "BernerBasisschrift1");
		AlexUtil.DrawText(new Vector2(20, 60), "Success ", 24, Color.black, "BernerBasisschrift1");

		GUI.skin = customBox;

		//Empty bar
		GUI.BeginGroup(new Rect(position.x, position.y, size.x, size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), emptybar);
		GUI.EndGroup();

		//Bar fills only up to the size of x, cut off by the percentage of current wealth
		GUI.BeginGroup(new Rect(position.x, position.y, size.x * 0.3f, size.y));
		GUI.Box(new Rect(0,0, size.x, size.y), fullbar);
		GUI.EndGroup();
	}
}
