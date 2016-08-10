using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public Transform BulletSpawner; 
	public GameObject bulletPrefab;
	public GameObject PowerUpPrefab; 
	public float ShotRestriction; 
	public float TimeLeft = 1f; 


	// Use this for initialization
	void Start () {
	
	}

	
	public float speed = 1.0f;
	
	void Update() {
		var move = new Vector3(0,Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
		PlayerShooting (); 
		TestPowerUp (); 
	}

	public void PlayerShooting() {

		if (ShotRestriction <= 1) {
			if (Input.GetButtonDown ("Fire1")) {

				Instantiate (bulletPrefab, BulletSpawner.position, BulletSpawner.rotation); 
				ShotRestriction++; 

			} 
		} else {
			
			TimeLeft -= Time.deltaTime; 
			if (TimeLeft < 0) 
			{
				ShotRestriction = 0; 
				TimeLeft = 1f; 
				
			}
			
		}


	}
	public void TestPowerUp () 
	{

		if (Input.GetButtonDown ("Fire2")) {
			
			Instantiate (PowerUpPrefab , BulletSpawner.position, BulletSpawner.rotation); 
			
		} 
	
	
	}


}
