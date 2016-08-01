using UnityEngine;
using System.Collections;

public class Test_Move : MonoBehaviour {

	public float speed = 0f; 
	public float movex = 0f; 
	public float movey = 0f; 

	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ();
	
	}
}
