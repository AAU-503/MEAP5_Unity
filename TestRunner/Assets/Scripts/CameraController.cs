﻿using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public Transform player;
    public float speed = 0.1f; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(speed, 0, 0);
	}
}