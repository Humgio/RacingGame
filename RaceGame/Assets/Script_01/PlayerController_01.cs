using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_01 : MonoBehaviour {
    public float tilt;
    [Range(0.0f, 50f)]
    public float hoverHeight, hoverForce, hoverDamp, speed;
    public bool hovering,Grounded;

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        hovering = false;
	}
	
	// Update is called once per frame
	void Update () {
        //When the player is hovering and not Grounded he can move from left to right
        if (hovering == true && Grounded == false)
        {
            rb.rotation = Quaternion.Euler(rb.velocity.z * +tilt, 0.0f, 0.0f);
            Vector3 dwd = transform.TransformDirection(Vector3.down);
            Vector3 thrustPosition = this.transform.position;
            if (Physics.Raycast(transform.position, dwd, 10f))
            {
                rb.AddExplosionForce(hoverForce, dwd, 3.0f);
            }
            if (this.transform.position.y > 8)
            {
                float moveHorizontal = Input.GetAxis("Horizontal");

                Vector3 movement = new Vector3(moveHorizontal, 0.0f,speed);
                rb.velocity = movement * speed;
            }
        }
        if (Input.GetButtonDown("Hover"))
        {
            if (hovering == true)
            {
                //Sets hovering to false if its already true and then prints the text in the Console.
                hovering = false;
                print("hovering is "+ hovering);
            }
            else
            {
                //When the player presses the hover button (Space) it will set Hover to true if its false and vice versa with the Grounded value.
                hovering = true;
                Grounded = false;
                rb.AddForce(Vector3.down * hoverForce);
                print("hovering is "+ hovering);
            }
               
        }
    }
    void OnCollisionEnter(Collision other)
    {
        // When the Car(PlayerController) Collides the game object with the tag Ground it will set Grounded to True.
        if (other.gameObject.CompareTag("Ground"))
        {
            Grounded = true;
            //If grounded the console will print this text.
            if (Grounded == true)
            {
                print("You are Grounded");
            }
           
        }
    }
}
