using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour {

	public GameObject enemy;
	public float tiempo=  1.75f;
	public float levelWidth=3f;
	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateEnemy",0f,tiempo);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void CreateEnemy(){
		Vector3 spawnPosition=new Vector3();
		spawnPosition.y = transform.position.y ; 
			spawnPosition.x = Random.Range(-levelWidth,levelWidth); 
		Instantiate(enemy,spawnPosition,Quaternion.identity);
	}
}
