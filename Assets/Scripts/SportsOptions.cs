using UnityEngine;
using System.Collections;

public class SportsOptions : MonoBehaviour {

	public GameObject Ball;
	public GameObject Child;
	float timer = 0.0f;
	Vector3[] ballPositions = {
		new Vector3 (0, -2, 0),
		new Vector3 (-5, -2, 0),
		new Vector3 (5, -2, 0)
	};

	// Use this for initialization
	IEnumerator Start () {
		//Instantiate (Ball, new Vector3 (0, -2, 0), Quaternion.identity);
		while (true) {
			yield return StartCoroutine(CreateBall());
		}
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (Random.Range (0, 450) == 225) {
			Instantiate (Child, new Vector3 (Random.Range (-4, 6), 2, 0), Quaternion.identity);
		}

		/*if (timer >= 5.0f) {
			Instantiate (Ball, ballPositions[Random.Range (0, 3)], Quaternion.identity);
			timer = 0.0f;
		} */

	}

	IEnumerator CreateBall() {
		Instantiate (Ball, ballPositions[Random.Range (0, 3)], Quaternion.identity);
		yield return new WaitForSeconds(5.0f);
	}

}
