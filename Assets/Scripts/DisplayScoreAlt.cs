using UnityEngine;
using System.Collections;

//Display of progress bars adapted from Unity Answers.
//http://answers.unity3d.com/questions/11892/how-would-you-make-an-energy-bar-loading-progress.html

public class DisplayScoreAlt : MonoBehaviour {

	public Texture2D w_barContent;
	public Texture2D j_barContent;
	public Texture2D s_barContent;
	public Texture2D barEdges;
	public float w_amt;
	public float j_amt;
	public float s_amt;
	
	// Use this for initialization
	void Start () {
		s_amt = .5f;
	}
	
	// Update is called once per frame
	void Update () {
		w_amt = VariableControl.Wealth*0.01f;

		if (VariableControl.Jerk >= 100) {
			VariableControl.Jerk = 100;
		}

		j_amt = VariableControl.Jerk*0.01f;

		s_amt = VariableControl.Success*0.01f;
	}
	
	void OnGUI () {

		AlexUtil.DrawText(new Vector2(Screen.width - 150, 15), "Day " + VariableControl.Day, 36, Color.black, "BernerBasisschrift1");
		AlexUtil.DrawText(new Vector2(20, 15), "Wealth ", 24, Color.black, "BernerBasisschrift1");
		AlexUtil.DrawText(new Vector2(45, 50), "Jerk ", 24, Color.black, "BernerBasisschrift1");
		AlexUtil.DrawText(new Vector2(20, 85), "Success ", 24, Color.black, "BernerBasisschrift1");
		//AlexUtil.DrawText(new Vector2(20, 105), "Success " + VariableControl.Success.ToString ("0"), 24, Color.black, "BernerBasisschrift1");
		
		//wealth
		GUI.DrawTextureWithTexCoords(
			new Rect(70,0, w_amt*barEdges.width*0.75f, barEdges.height*0.5f), 
			w_barContent, new Rect(0,0,w_amt, 1) 
			);

		GUI.DrawTexture(new Rect(70,0, barEdges.width*0.75f, barEdges.height*0.5f), barEdges);

		//jerk
		GUI.DrawTextureWithTexCoords(
			new Rect(70,35, j_amt*barEdges.width*0.75f, barEdges.height*0.5f), 
			j_barContent, new Rect(0,0,j_amt, 1) 
			);
		
		GUI.DrawTexture(new Rect(70,35, barEdges.width*0.75f, barEdges.height*0.5f), barEdges);

		//success
		GUI.DrawTextureWithTexCoords(
			new Rect(70,70, s_amt*barEdges.width*0.75f, barEdges.height*0.5f), 
			s_barContent, new Rect(0,0,s_amt, 1) 
			);
		
		GUI.DrawTexture(new Rect(70,70, barEdges.width*0.75f, barEdges.height*0.5f), barEdges); 

	}
}
