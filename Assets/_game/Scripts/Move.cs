using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	public Transform BulletSpawner; 
	public GameObject bulletPrefab;

	// Use this for initialization
	void Start () {
	
	}

	
	public float speed = 1.0f;
	
	void Update() {
		var move = new Vector3(0,Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
		PlayerShooting (); 
	}

	public void PlayerShooting() {

		if (Input.GetButtonDown("Fire1"))
		    {

			Instantiate(bulletPrefab , BulletSpawner.position , BulletSpawner.rotation); 

		}


	}

}
