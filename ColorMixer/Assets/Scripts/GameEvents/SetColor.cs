using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetColor : MonoBehaviour {

    public Renderer rend;
    public Color newColor;

	// Use this for initialization
	void Start () {
        SetObjectColor();
	}
    //Set color of the object.
    public void SetObjectColor()
    {
        rend = gameObject.GetComponent<Renderer>();
        rend.material.color = newColor;
        Debug.Log(newColor);
    }
    public void getColorValue()
    {
        GameObject blend = GameObject.Find("Blender");
        Blender other = (Blender)blend.GetComponent(typeof(Blender));
        other.Blend(newColor);
    }
}
