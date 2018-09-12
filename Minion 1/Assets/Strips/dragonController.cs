using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragonController : MonoBehaviour {

public float velocity=5f;
	private Rigidbody2D rb;
	
	void Start () {
		rb= GetComponent<Rigidbody2D>();
		rb.velocity=Vector2.down * velocity;
	}
	
	
}
