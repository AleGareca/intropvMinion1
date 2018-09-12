using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	public float velocity=2f;
	private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb= GetComponent<Rigidbody2D>();
		rb.velocity=Vector2.up * velocity;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
}
