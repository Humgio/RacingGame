using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour {
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("we hit");
    }
}
