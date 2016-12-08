using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoverMode : MonoBehaviour {

    public float hoverHeight = 4.0f;
    public float hoverForce = 5.0f;
    public float hoverDamp = 0.5f;
    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void FixedUpdate()
    {
        Vector3 dwd = transform.TransformDirection(Vector3.down);
        Vector3 thrustPosition = transform.position;

        if (Physics.Raycast(transform.position, dwd,10))
        {
            rb.AddExplosionForce(hoverForce, thrustPosition, 0.0f, 1.0f);       
        }
    }
}
