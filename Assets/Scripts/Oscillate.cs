using UnityEngine;
using System.Collections;

//Adapted from this unity answer: 
//http://answers.unity3d.com/questions/14279/make-an-object-move-from-point-a-to-point-b-then-b.html

public class Oscillate : MonoBehaviour {

	Vector3 pointB = new Vector3(5, 3.5f, 0);
	
	IEnumerator Start()
	{
		Vector3 pointA = transform.position;
		while (true) {
			//Coroutines allow for function to happen over multiple frames
			//One coroutine finishes before the other coroutine starts
			yield return StartCoroutine(MoveObject(transform, pointA, pointB, 7.0f));
			yield return StartCoroutine(MoveObject(transform, pointB, pointA, 7.0f));
		}
	}


	//Lerp gradually moves an object from position A to position B, yielding after each movement
	IEnumerator MoveObject(Transform thisTransform, Vector3 startPos, Vector3 endPos, float time)
	{
		float i = 0.0f;
		float rate = 1.0f/time;
		while (i < 1.0f) {
			i += Time.deltaTime * rate;
			thisTransform.position = Vector3.Lerp(startPos, endPos, i);
			yield return null; 
		}
	}


	/*public Transform startMarker;
	public Transform endMarker;
	Transform placeholder;
	public float speed = 1.0f;
	public float distCovered;
	public float fracJourney;
	private float startTime;
	private float journeyLength;

	void Start() {
		startTime = Time.time;
		journeyLength = Vector3.Distance(startMarker.position, endMarker.position);
		placeholder = startMarker;
	}

	void Update() {
		distCovered = (Time.time - startTime) * speed;
		fracJourney = distCovered / journeyLength;
		transform.position = Vector3.Lerp(startMarker.position, endMarker.position, fracJourney);

		if (transform.position == endMarker.position) {
			placeholder.position = startMarker.position;
			print (placeholder.position);
			startMarker.position = endMarker.position;
			endMarker.position = placeholder.position;
			print(endMarker.position);
			print (startMarker.position);
			startTime = Time.time;
		}
	} */
}
