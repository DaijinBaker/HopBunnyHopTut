﻿using UnityEngine;
using System.Collections;

public class BunnyController : MonoBehaviour {

    private Rigidbody2D myRigidBody;
    public float bunnyjumpForce = 500f;

	// Use this for initialization
	void Start () {
        myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	 if (Input.GetButtonUp("Jump"))
        {
            myRigidBody.AddForce(transform.up * bunnyjumpForce);
        }
	}
}
