using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour {
    [SerializeField]
    private float r = 255;
    [SerializeField]
    private float g = 0;
    [SerializeField]
    private float b = 0;
    Renderer rend;
	// Use this for initialization
	void Start () {
       rend = gameObject.GetComponent<Renderer>();
    }
	
	// Update is called once per frame
	void Update () {
        rend.material.color = new Vector4(r, g, b, 0);
    }
}
