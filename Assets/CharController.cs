
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {
    Rigidbody2D myChar;

    Animator charAnim;

    public Transform groundCheck;

    public LayerMask ground;

    float groundRadius = 0.2f;

    bool isGrounded = false;
    public float maxSpeed = 10.0f;

    public float jumpForce = 700.0f;

        //Private variables to track whether or not character is facing left or right or if our double jump has been used.
    bool facingRight = true;
    bool facingLeft = false;
    bool doubleJump = false;



	// Use this for initialization
	void Start () {
        myChar = GetComponent<Rigidbody2D> ();
        charAnim = GetComponent<Animator> ();

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
