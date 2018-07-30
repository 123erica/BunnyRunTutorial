using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunnyjump : MonoBehaviour {

    private Rigidbody2D myRigidBody2d;

    public float bunnyjumpforce = 500f; 

	// Use this for initialization
	void Start () {
        myRigidBody2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonUp("Jump"))
        {
            myRigidBody2d.AddForce(transform.up * bunnyjumpforce);
        }
	}
}
