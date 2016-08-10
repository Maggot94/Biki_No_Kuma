using UnityEngine;
using System.Collections;

public class TestPowerUp : MonoBehaviour {

	
	private Rigidbody2D PowerUpRB;
	public float PowerUpspeed = 0f;
	public float PowerUplife = 0f; 
	
	void Awake () {
		
		PowerUpRB = GetComponent<Rigidbody2D> (); 
	}
	
	// Use this for initialization
	void Start () {
		
		PowerUpRB.velocity = new Vector2 (PowerUpspeed, PowerUpRB.velocity.y); 
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Destroy (gameObject, PowerUplife); 
		
	}
}