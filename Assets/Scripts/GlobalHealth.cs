using UnityEngine;
using System.Collections;

public class GlobalHealth : MonoBehaviour {
	/*
	public float health;
	public float points;
	public static float end_score;
	private GameObject Seita;
	private GameObject Setsuko;

	
	// Use this for initialization
	void Start () {

		health = 100.0f;
		points = 0.0f;

		//Predetermine the public GameObject variables for the prefab.
		Seita = GameObject.Find ("Seita");
		Setsuko = GameObject.Find ("Setsuko");
	}

	void Update () {

		//If Seita and Setsuko are too far away from each other, health is depleted incrementally. 
		float PlayerDist = (Vector3.Distance(Seita.transform.position, Setsuko.transform.position));
		if (PlayerDist > 10.0f)
			health -= Time.deltaTime / 3;

		end_score = health + points;

		//Game over if health drops below 0.
		if (health <= 0) {
			health = 0;
			end_score = health + points;
			Invoke ("goToLoseScreen", 2);
		}
	}

	void OnGUI () {
		GUI.Box (new Rect (10, 10, 150, 20), "Health Remaining: " + health.ToString ("0"));
		GUI.Box (new Rect ((Screen.width)/2 + 10, 10, 150, 20), "Health Remaining: " + health.ToString ("0"));
		GUI.Box (new Rect ((Screen.width)/2 - 75, (Screen.height) - 30, 150, 20), "Score: " + points.ToString ("0"));
	}

	void goToLoseScreen()
	{
		Application.LoadLevel("lose_screen");
	}
	*/
}
