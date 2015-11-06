using UnityEngine;
using System.Collections;


public class SimpleMover2D : MonoBehaviour {
	
	public KeyCode upKey = KeyCode.UpArrow;
	public KeyCode downKey = KeyCode.DownArrow;
	public KeyCode leftKey = KeyCode.LeftArrow;
	public KeyCode rightKey = KeyCode.RightArrow;
	
	public float movementSpeed = 10;
	bool jumpOk = false;
	
	Bounds wholeBounds; //used to get rought length, width and height of player
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Vector3 moveDirection = new Vector3(0, 0, 0);
		if (Input.GetKey(upKey))
		{
			moveDirection += new Vector3(0,movementSpeed,0);
		} 
		
		if (Input.GetKey(downKey))
		{
			moveDirection += new Vector3(0,-movementSpeed,0);
		}
		
		if (Input.GetKey(leftKey))
		{
			moveDirection += new Vector3(-movementSpeed,0,0);
		} 
		
		if (Input.GetKey(rightKey))
		{
			moveDirection += new Vector3(movementSpeed,0,0);
		}
		
		
		
		
		GetComponent<Rigidbody2D>().velocity = moveDirection;
		
		
		
	}
	
	
	
	
	
}
