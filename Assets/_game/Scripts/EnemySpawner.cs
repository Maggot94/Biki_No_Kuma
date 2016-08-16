using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public int Noleada = 15; 
	public Transform EnemySpawner1 ; 
	public GameObject Enemy1Prefab; 
	public GameObject Enemy2Prefab; 
	public GameObject Enemy3Prefab;
	public GameObject Enemy4Prefab; 
	public bool end = true;
	public bool DeployEnemy = false;
	public bool DeployEnemy1 = false;
	public bool DeployEnemy2 = false;
	public bool DeployEnemy3 = false;
	public bool DeployEnemy4 = false;
	public float TimeLeft = 10f; 
	public float TimeEnemy = 10f;
	public float Timeint = 10f; 

	// Use this for initialization
	void Start () {

		end = true;
		Noleada = 15; 
		TimeEnemy = 10f;
        TimeLeft = 10f; 

	
	}
	
	// Update is called once per frame
	void Update () {
		Delay (); 
			if (end == true) {
				TimeLeft -= Time.deltaTime;
				if (TimeLeft < 0) {
					Noleada = Noleada - 1;
					TimeLeft = 3f; 
					end = false; 
					if (Noleada >= 1 && end == false) {
						switch (Noleada) {
						case 14:
							if (DeployEnemy == true) {
								Instantiate (Enemy1Prefab, EnemySpawner1.position, EnemySpawner1.rotation);
							}
							if (DeployEnemy1 == true) {
								Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation);

							}
							if (DeployEnemy2 == true) {
								Instantiate (Enemy3Prefab, EnemySpawner1.position, EnemySpawner1.rotation);

							}
							if (DeployEnemy3 == true) {
								Instantiate (Enemy4Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 

							}
							if (DeployEnemy4 == true) {
								end = false;

							}
							break; 
						case 13: 
						
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation);  
							end = true;
							break; 
						
						case 12: 
						
							Instantiate (Enemy3Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy4Prefab, EnemySpawner1.position, EnemySpawner1.rotation);
							end = true;
							break; 
						
						case 11: 
						
							Instantiate (Enemy3Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							end = true;
							break;
						
						case 10:
							Instantiate (Enemy4Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy3Prefab, EnemySpawner1.position, EnemySpawner1.rotation);
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							end = true;
							break; 
						
						
						case 9:
						
							Instantiate (Enemy4Prefab, EnemySpawner1.position, EnemySpawner1.rotation);
							end = true;
						
							break; 
						
						case 8:
						
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							end = true;
						
							break;
						
						case 7:
						
							Instantiate (Enemy1Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy3Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy4Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							end = true;
						
							break; 
						
						case 6: 
						
							Instantiate (Enemy1Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							end = true;
						
							break;
						
						case 5:
						
							Instantiate (Enemy3Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy4Prefab, EnemySpawner1.position, EnemySpawner1.rotation);
							end = true;
						
							break; 
						
						case 4: 
						
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							end = true;
						
							break; 
						
						case 3: 
						
							Instantiate (Enemy4Prefab, EnemySpawner1.position, EnemySpawner1.rotation);
							Instantiate (Enemy3Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							end = true;
						
							break; 
						
						case 2:
						
							Instantiate (Enemy2Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							Instantiate (Enemy3Prefab, EnemySpawner1.position, EnemySpawner1.rotation);
							end = true;
						
							break; 
						
						case 1: 
						
							Instantiate (Enemy4Prefab, EnemySpawner1.position, EnemySpawner1.rotation);
							Instantiate (Enemy3Prefab, EnemySpawner1.position, EnemySpawner1.rotation); 
							end = true;
						
							break; 
						
						
						}
					
					}
				}
			}

	}

	void Delay () 
	{   
		DeployEnemy = true; 
		TimeEnemy -= Time.deltaTime; 
		if (TimeEnemy <= 8) {
			
			DeployEnemy1 = true; 
			
		}
		if (TimeEnemy <= 6) {
			
			DeployEnemy2 = true; 
			
		}
		if (TimeEnemy <= 4) {
			
			DeployEnemy3 = true; 
			
		}
		if (TimeEnemy <= 2) {
			
			DeployEnemy4 = true; 

		}

		if (TimeEnemy <= 0) {

		DeployEnemy = false; 
		DeployEnemy1 = false; 
		DeployEnemy2 = false; 
		DeployEnemy3 = false; 
		DeployEnemy4 = false;
			TimeEnemy = 10f; 
	}

	}
}


	



	

