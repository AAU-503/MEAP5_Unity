using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class HazardCollision : MonoBehaviour {

	void OnTriggerEnter(Collider collide){
		if(collide.gameObject.name == "Tile_Lava") {
			Debug.Log("Lava");
		}
		
	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.name == "Cube"){
			Debug.Log("BOX");
		}
	} 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}
}
