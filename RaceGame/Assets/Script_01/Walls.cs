using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour {

    PlayerController_01 playerController;
    public Rigidbody rb;
    void Start()
    {
    }
    void OnCollisionEnter(Collision other)
    {
        Vector3 ExplosionPos = playerController.transform.position;
        if (other.gameObject.CompareTag("Player"))
        {
            print("Dont touch the wall it will kill you!");
            playerController.hovering = false;
            rb.AddExplosionForce(10f, ExplosionPos, 5f, 3.0f);
        }

    }
}
