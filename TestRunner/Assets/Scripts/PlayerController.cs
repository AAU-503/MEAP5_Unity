using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public CameraController cameraController; 

	// Use this for initialization
	void Start () {
        cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(cameraController.speed,0,0); 
	}
}
