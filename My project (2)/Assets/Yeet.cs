using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yeet : MonoBehaviour
{
    public float xSpread;
    public float zSpread;
    public float yOffset;

    public Transform centerPoint;

    public float speed;
    public bool rotateClockwise;

    float time = 0;
    float x;
    float z;
    void Update()
    {
        time += Time.deltaTime * speed;
        Rotate();
        transform.LookAt(centerPoint);
    }

    private void Rotate()
    {
        if(rotateClockwise)
        {
            x = -Mathf.Cos(time) * xSpread;
            z  = Mathf.Sin(time) * zSpread;
        }
        else
        {
            x = Mathf.Cos(time) * xSpread;
            z = Mathf.Sin(time) * zSpread;
        }
        Vector3 pos = new Vector3(x, yOffset, z);
        transform.position = pos + centerPoint.position;
    }
}
