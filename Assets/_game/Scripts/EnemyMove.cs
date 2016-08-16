using UnityEngine;
using System.Collections;

public class EnemyMove : MonoBehaviour {

	// Use this for initialization
	private Rigidbody2D EnemyRB;
	public float Enemyspeed = 0f;


	
	void Awake () {
		
		EnemyRB = GetComponent<Rigidbody2D> (); 
		EnemyRB.velocity = new Vector2 (Enemyspeed, EnemyRB.velocity.y); 
	}
	
	// Use this for initialization
	void Update () {
		

	

		
	}




}

