using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject go1;
    public GameObject go2;
    public GameObject go3;

    GameObject[] spawnObject;

    [SerializeField] float firstSpawn = 4;
    [SerializeField] float spawnRate = 8;
    [SerializeField] float chance = 75;

    Vector3 bordes;
    void Start()
    {
        spawnObject = new GameObject[3];
        spawnObject[0] = go1;
        spawnObject[1] = go2;
        spawnObject[2] = go3;

        bordes = GetComponent<Collider2D>().bounds.extents;
        Invoke("Spawn", firstSpawn);
        InvokeRepeating("IncreaseRate", 10, 15);
    }


    void Spawn()
    {
        int rnd = Random.Range(0, 101);
        Vector3 spawnPoint = new Vector3(Random.Range(transform.position.x - bordes.x, transform.position.x + bordes.x), transform.position.y, 0);
        if (rnd > chance)
            Instantiate(spawnObject[Random.Range(0, 3)], spawnPoint, transform.rotation);
        else Instantiate(spawnObject[2], spawnPoint, transform.rotation);
        Invoke("Spawn", spawnRate);
    }


    void IncreaseRate()
    {
        if (spawnRate >= 2f)
            spawnRate -= 0.2f;
    }
}
