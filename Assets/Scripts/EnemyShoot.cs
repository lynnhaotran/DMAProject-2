using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

	public GameObject Seita;
	public GameObject Setsuko;
	public GameObject BulletToCopy;
	bool shoot = false;
	public float timeShoot = 0.0f;
	
	// Use this for initialization
	void Start () {
		
		//Predetermine the public GameObject variables for the prefab.
		Seita = GameObject.Find ("Seita");
		Setsuko = GameObject.Find ("Setsuko");
	}
	
	// Update is called once per frame
	void Update () {

		float EnemytoSeitaDist = (Vector3.Distance(Seita.transform.position, this.transform.position));
		if (EnemytoSeitaDist <= 25.0f) {
			this.transform.LookAt(new Vector3 (Seita.transform.position.x, 
			                                                    this.transform.position.y,
			                                                    Seita.transform.position.z));
			shoot = true;
		}
		
		float EnemytoSetsuDist = (Vector3.Distance(Setsuko.transform.position, this.transform.position));
		if (EnemytoSetsuDist <= 25.0f) {
			this.transform.LookAt(new Vector3 (Setsuko.transform.position.x, 
			                                                    this.transform.position.y,
			                                                    Setsuko.transform.position.z));
			shoot = true;
		}

		if (shoot) {
			timeShoot += Time.deltaTime;
			if (timeShoot >= 1.0f) {
				Instantiate (BulletToCopy, this.transform.position, 
			             this.transform.rotation);
				timeShoot = 0.0f;
			}
		else
			shoot = false;
		}

	}

	/*void OnTriggerStay(Collider other) {
		if (other.gameObject.GetComponent<SetsukoInfo> () != null) {
			this.transform.parent.transform.LookAt(new Vector3 (Setsuko.transform.position.x, 
			                                                    this.transform.parent.transform.position.y,
			                                                    Setsuko.transform.position.z));
			shoot = true;
		} 
		if (other.gameObject.GetComponent<SeitaInfo> () != null) {
			this.transform.parent.transform.LookAt(new Vector3 (Seita.transform.position.x, 
			                                                    this.transform.parent.transform.position.y,
			                                                    Seita.transform.position.z));
			shoot = true;
		} 
	}

	//Stop shooting when out of range.
	void OnTriggerExit(Collider other) {
		if (other.gameObject.GetComponent<SeitaInfo> () != null || other.gameObject.GetComponent<SetsukoInfo> () != null)
			shoot = false;
	} */

}
