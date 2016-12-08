using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiskProjectile : MonoBehaviour {
    public float bulletSpeed,rotationSpeed;
    public GameObject projectile;
	// Use this for initialization
	void Start () {
        GameObject projectile = GetComponent < GameObject > ();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * bulletSpeed,Space.World);
        transform.RotateAround(Vector3.up, rotationSpeed);
        transform.Rotate(Vector3.up,rotationSpeed);
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
        }
        
    }
}
