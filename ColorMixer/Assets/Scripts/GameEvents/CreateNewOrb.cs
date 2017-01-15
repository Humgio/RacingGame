using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CreateNewOrb : MonoBehaviour {

    public SetColor objectPrefab;
    public Color blendedColor;

    public void CreateNew(Color colr)
    {
        SetColor clone = Instantiate(objectPrefab, transform.position, Quaternion.identity);
        clone.newColor = blendedColor;
        blendedColor = new Color(0, 0, 0, 0);
    }
}
