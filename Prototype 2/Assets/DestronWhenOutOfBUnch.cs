using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestronWhenOutOfBUnch : MonoBehaviour
{
    public float maxZBound = 30;
    public bool graterThen = false;

    private Func<float, bool> comper;
    void Start()
    {
        if (graterThen)
        {
            comper = (x) => x > maxZBound;
        }
        else
        {
            comper = (x) => x < maxZBound;
        }
    }
    void Update()
    {
        if(comper(transform.position.z))
        {
            Destroy(gameObject);
        }
    }
}
