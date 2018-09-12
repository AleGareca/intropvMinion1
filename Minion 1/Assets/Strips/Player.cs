using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour {
	 public float velocityMove=10f;
	
	Rigidbody2D rb;
	
	 float movimiento=0f;
	// Use this for initialization
	void Start () {
		rb=GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {
	 movimiento= Input.GetAxis("Horizontal")*velocityMove;
	

	}

	

	void FixedUpdate(){
		Vector2 velocity= rb.velocity;
		velocity.x=movimiento;
		rb.velocity=velocity;
		if(movimiento> 0.1f){
			transform.localScale=new Vector3(1f,1f,1f);
		}
		if(movimiento< -0.1f){
			transform.localScale=new Vector3(-1f,1f,1f);
		}
	}
	
	
}
