using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestronWhenOutOfBUnch : MonoBehaviour
{
    public float maxZBound = 30;

    void Start()
    {

    }
    void Update()
    {
        if(transform.position.z > 40 || transform.position.z < -40)
        {
            Destroy(gameObject);
        }
    }
}
