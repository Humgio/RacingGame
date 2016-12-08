using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ObjectSpawner : MonoBehaviour
{

    public GameObject obstacle;
    public float Speed = 1.0f;
    public int obsticalLife = 1;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(SpawnerRoutine());
    }
    // Update is called once per frame
    void Update()
    {


    }
    void SpawnerInstantiater()
    {
        Vector3 obsposition = new Vector3(0.0f, 0.5f, 50f);
        Instantiate(obstacle, obsposition, Quaternion.identity);
    }
    IEnumerator SpawnerRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(3f);
            SpawnerInstantiater();
            yield return new WaitForSeconds(1f);
            SpawnerInstantiater();
            yield return new WaitForSeconds(1.5f);
            SpawnerInstantiater();
            yield return new WaitForSeconds(1f);
        }
    }
}