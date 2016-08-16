using UnityEngine;
using System.Collections;

public class EnemyTagFinder : MonoBehaviour {

	private Rigidbody2D EnemyRB;
	public float EnemyDownspeed = 0f;
	public float Enemyspeed = 0f;
	public bool found = false ; 
	public float Timeleft = 1f;
	public string Tag; 


	void Awake () {
		
		EnemyRB = GetComponent<Rigidbody2D> (); 
		EnemyRB.velocity = new Vector2 (Enemyspeed, EnemyRB.velocity.y); 
	}

	void Update (){

		if (found == true) {

			Timeleft -= Time.deltaTime;

			if ( Timeleft < 0 ){
				
				EnemyRB.velocity  = new Vector2 ( 0 , EnemyDownspeed ); 
			}


		}

	}


	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.gameObject.tag == Tag ) {
			found = true; 
			EnemyRB.velocity = new Vector2 ( 0,0); 
		
			}
		}



}
