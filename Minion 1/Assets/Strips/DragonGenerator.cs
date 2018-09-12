using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonGenerator : MonoBehaviour {
	public GameObject enemy;
	public float tiempo=  1.7f;
	public float levelWidth=5f;

	void Start () {
		InvokeRepeating("CreateEnemy",5f,tiempo);
	}
	
	
	void Update () {
		
	}
	void CreateEnemy(){
		Vector3 spawnPosition=new Vector3();
		spawnPosition.y = transform.position.y ; 
			spawnPosition.x = Random.Range(-levelWidth,levelWidth); 
		Instantiate(enemy,spawnPosition,Quaternion.identity);
	}
}
