﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroll : MonoBehaviour {

    public float speed = 0.1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector2 offset = new Vector2(0, Time.time * speed);
        this.GetComponent<Renderer>().material.mainTextureOffset = offset;

	}
}
