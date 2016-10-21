using UnityEngine;
using System.Collections;

public class CollisionScript : MonoBehaviour {

	// Update is called once per frame
	void Update () {
        
      
        	
	}

    void OnCollisionEnter2D(Collision2D collision) {

            Debug.Log(collision.gameObject.tag);

    }
}
