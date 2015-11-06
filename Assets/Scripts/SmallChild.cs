using UnityEngine;
using System.Collections;

public class SmallChild : MonoBehaviour {

	float SmallChildLife = 7.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		SmallChildLife -= Time.deltaTime;
		
		if (SmallChildLife <= 0)
			Destroy (this.gameObject);
	}
}
