using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blender : MonoBehaviour
{
    public Color blended;
    public CreateNewOrb crNew;
    public Transform objPos;
    public float objCount = 0;
    public void Start()
    {
        crNew.GetComponent<CreateNewOrb>();
    }
    public void Blend(Color colors)
    {
        blended += colors;
        objCount++;
        if (objCount == 2)
        {
            crNew.CreateNew(blended);
            Debug.Log(blended);
            objCount = 0;
        }
    }
}
