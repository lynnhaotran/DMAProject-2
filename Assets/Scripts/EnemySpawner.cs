using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour {

	/*private int MaxNumberEnemies = 20;
	public GameObject enemy;
	public List<GameObject> enemies = new List<GameObject>();

	// Use this for initialization
	void Start () {

		//Randomly spawn max enemies at initialization
		for (int i = 0; i != MaxNumberEnemies; i++) {
			enemies.Add(Instantiate(enemy, new Vector3(Random.Range(-50.0f, 50.0f), 1, 
			                                           Random.Range(-50.0f, 50.0f)), Quaternion.identity) as GameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {

		//Check whether the enemy has been killed. If it has been killed, then we respawn another in a random interval.

		for (int i = 0; i != enemies.Count; i++) {
			if (enemies [i] != null) {
				EnemyInfo life = enemies[i].GetComponent<EnemyInfo> ();
				if (life.isDead) {
					Destroy (enemies[i]);
					enemies[i] = null;
					//print ("Respawning " + i);
					Invoke ("Respawn", Random.Range(15.0f, 30.0f));
				}
			}
		}
	}

	//Called to repopulate a single enemy
	void Respawn() {
		enemies.Add(Instantiate(enemy, new Vector3(Random.Range(-50.0f, 50.0f), 1, 
		                                           Random.Range(-50.0f, 50.0f)), Quaternion.identity) as GameObject);
	} */
}
