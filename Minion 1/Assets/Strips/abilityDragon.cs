using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class abilityDragon : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		
		if (other.tag == "Player") {
			SceneManager.LoadScene("Game Over");
			return;
		}
		
		/*if  (other.gameObject.tag == "plataforma") {
			Destroy (other.gameObject);
			
			
		} */
		
	}

}
