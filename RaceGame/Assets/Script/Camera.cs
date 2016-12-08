using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject target;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPosition = target.transform.position - Vector3.forward * 35f + Vector3.up * 20f;
        transform.position = Vector3.Lerp(transform.position, cameraPosition, 0.08f);

        transform.LookAt(target.transform);
    }
}