using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	private Rigidbody2D bulletRB;
	public float bulletspeed = 0f;
	public float bulletlife = 0f; 

	void Awake () {

		bulletRB = GetComponent<Rigidbody2D> (); 
	}

	// Use this for initialization
	void Start () {

		bulletRB.velocity = new Vector2 (bulletspeed, bulletRB.velocity.y); 
	
	}
	
	// Update is called once per frame
	void Update () {

		Destroy (gameObject, bulletlife); 
	
	}
}
