using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    Rigidbody rb;
    RaycastHit hit;

    [Range(0.0f, 100f)]
    public float speed, hoverHeight, hoverForce,moveForward,bulletSpeed;
    public float xMin,xMax;
    public bool hovering, grounded;
    public Transform ProjSpawn;
    public GameObject discProjectile, projectileClone;
    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (hovering == true && grounded == false)
        {
            Vector3 dwd = transform.TransformDirection(Vector3.down);
            if (Physics.Raycast(transform.position, dwd, hoverHeight))
            {
                rb.AddForce(Vector3.up * hoverForce);
            }
            float moveHorizontal = Input.GetAxis("Horizontal") * speed;
            moveHorizontal *= Time.deltaTime;
            transform.Translate(moveHorizontal, 0f,0f);
        }
        if (Input.GetButtonDown("Hover"))
        {
            if(hovering == true)
            {
                hovering = false;
                grounded = true;
                print("hovering is " + hovering);
            }
            else
            {
                hovering = true;
                grounded = false;
            }
        }
        if (Input.GetButtonDown("Shoot"))
        {
            projectileClone = Instantiate(discProjectile,ProjSpawn.position,Quaternion.identity) as GameObject;
            Destroy(projectileClone, 10f);
        }
    }
}
