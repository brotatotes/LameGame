﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

    float speed = 10.0f;

    // Use this for initialization
    void Start () {
        
	}

    // Update is called once per frame
    void Update()
    {
        var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position += move * speed * Time.deltaTime;
    }
}
