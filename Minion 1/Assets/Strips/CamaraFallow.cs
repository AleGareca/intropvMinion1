using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFallow : MonoBehaviour {

	public Transform target; 
	public float smoothSpeed=.1f;
	void LateUpdate () {
		if(target.position.y > transform.position.y){
			Vector3 newPosition= new Vector3(0f,target.position.y,transform.position.z);
			transform.position= newPosition;
		}	
	}
}
