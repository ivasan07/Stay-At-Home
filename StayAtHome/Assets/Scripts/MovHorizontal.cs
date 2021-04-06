using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovHorizontal : MonoBehaviour
{
    private Vector2 posOri;
    public float amplitud = 1, velHorizontal = 3, velVertical = 1;

    void Start()
    {
        posOri = transform.position;
    }

    void Update()
    {
        transform.position = transform.position + new Vector3(Mathf.Sin(Time.time * amplitud) * velHorizontal, velVertical, 0) * Time.deltaTime;
    }
}
