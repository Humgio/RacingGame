using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {
    public GameObject[] gameObject;
    public GameObject clone;
    [SerializeField]
    private float xMin, xMax,spawned;
    void Start()
    {
        StartCoroutine(Spawner());
    }
    IEnumerator Spawner()
    {
        //print(Time.time);
        yield return new WaitForSeconds(3);
        Spawn();
        yield return new WaitForSeconds(2);
        Spawn();
        //print(Time.time);
        StartCoroutine(Spawner());
    }
    void Spawn()
    {
        int rnd = Random.Range(0, 5);
        float posRnd = Random.Range(xMin, xMax);
        transform.position = new Vector3(posRnd, 0f, transform.position.z);
        clone = Instantiate(gameObject[rnd], transform.position, Quaternion.identity);
        Destroy(clone, 5);
    }
    // Update is called once per frame
    void Update () {
	}
}
