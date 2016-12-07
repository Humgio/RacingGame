using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour {
    private float speed = 2.5f;
    [SerializeField]
    private Renderer[] gate;
    // Use this for initialization
    void Start () {
    }
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.back * speed); 
        //Pulsating gate component
        gate[3].material.color = Color.Lerp(Color.yellow,Color.gray, Mathf.Sin(Time.time * 2));
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gate[2].material.color = Color.green;
        }  
    }
}
