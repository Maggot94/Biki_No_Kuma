using UnityEngine;
using System.Collections;

public class EnemyTagFinder : MonoBehaviour {

	private Rigidbody2D EnemyRB;
	private Animator osostate; 
	public float EnemyDownspeed = 0f;
	public float EnemyspeedInicial = 0f;
	public float EnemyspeedGround = 0f; 
	public bool found = false ; 
	public bool Contac = false; 
	public float Timeleft = 1f;
	public float TimeGround = 1f; 
	public float TimeDeath = 1f; 
	public string Tag; 
	public string GroundTag; 
	public float TimeEnemyDeath = 15f; 
	//public Paracaidas p; 





	void Awake () {
		
		EnemyRB = GetComponent<Rigidbody2D>(); 
		EnemyRB.velocity = new Vector2 (EnemyspeedInicial, EnemyRB.velocity.y); 
		osostate = GetComponent <Animator>(); 
	
	}

	void Update (){

	

		Destroy (gameObject, TimeEnemyDeath); 

		if (found == true) {

			Timeleft -= Time.deltaTime;
			osostate.SetInteger ("Osostate" , 1);

			if ( Timeleft < 0 ){
				
				EnemyRB.velocity  = new Vector2 ( 0 , EnemyDownspeed );
			 

			}

			/*if (p.Damage == true){

				TimeDeath -= Time.deltaTime; 
				osostate.SetInteger ("Osostate" , 2);

				if (TimeDeath < 0 ){

					Destroy (gameObject); 

				}

			}*/


		}
		if (Contac == true) {

			TimeGround -= Time.deltaTime; 
			osostate.SetInteger ("Osostate" , 0);

			if (TimeGround < 0 ){


				EnemyRB.velocity = new Vector2 (EnemyspeedGround ,0);
			}

		}

	}


	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.gameObject.tag == Tag) {
			found = true; 
			EnemyRB.velocity = new Vector2 (0, 0); 
		}
	

			if ( coll.gameObject.tag == GroundTag ){


				EnemyRB.velocity = new Vector2 (0,0);
				Contac = true; 
			}

		
		
	}




		
}






