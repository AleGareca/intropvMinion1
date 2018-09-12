using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lazo : MonoBehaviour {

public Transform from;
public Transform to;

void OnDrownGizmosSelected(){
	if(from != null && to != null){
		Gizmos.color=Color.cyan;
		Gizmos.DrawLine(from.position,to.position);
	}
	}
}
