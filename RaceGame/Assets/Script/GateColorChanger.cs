using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateColorChanger : MonoBehaviour {
    Renderer rend;
    // Use this for initialization
    void Start () {
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Color.red;
	}
	
	// Update is called once per frame
	void Update () {
	}

    void OnTriggerEnter(Collider other)
    {
        print("Change Color");
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = Color.green;
    }
}
