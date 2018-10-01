
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour {

    
    Rigidbody2D myChar;
    Animator charAnim;

    public float speed;
    public float jumpSpeed;
    public float gravity = 10.0f;

    Vector3 moveDirection = Vector3.zero;

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
        //check to see if 'groundcheck' transform is colliding with ground
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, ground);
        //tell animator if we are on the ground or not by updating our ground parameter 
        charAnim.SetBool("ground", isGrounded);

        if (isGrounded)
        {
            doubleJump = false;
        }
        charAnim.SetFloat("verticalSpeed", myChar.velocity.y);
      
	}
}
