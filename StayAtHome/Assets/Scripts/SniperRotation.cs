using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperRotation : MonoBehaviour
{
    public float rotSpeed = 5;
    void Update()
    {
        if (Time.timeScale != 0)
        {
            float rotation = transform.rotation.eulerAngles.z + Vector3.forward.z * rotSpeed;
            transform.Rotate(Vector3.forward * rotSpeed, Space.World);
            if (rotation > 145 && rotation < 180) rotSpeed = -rotSpeed;
            else if (rotation < 35 && rotation > 0) rotSpeed = -rotSpeed;
        }
    }
}
