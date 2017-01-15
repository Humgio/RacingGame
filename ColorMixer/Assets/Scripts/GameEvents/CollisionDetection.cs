using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log("The collision position = " + collision.transform.position / 2);
        ColorInformation();
        Destroy(collision.gameObject);

    }
    void ColorInformation()
    {
        SetColor colorVal = GetComponent<SetColor>();
        colorVal.getColorValue();
    }
}
