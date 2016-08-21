using UnityEngine;
using System.Collections;

public class Paracaidas : MonoBehaviour {
	public string Tag; 
	public bool Damage = false; 


	void Awake (){

		Damage = false; 

	}

	void OnCollisionEnter2D(Collision2D coll){

		if (coll.gameObject.tag == Tag) {

			Damage = true; 
		}

	}


}
