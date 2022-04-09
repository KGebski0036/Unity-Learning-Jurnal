using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatTheBackground : MonoBehaviour
{
    private Vector3 startPosition;
    private float repeatWidth;
    private int numberOfRepitingFragments = 2;
    void Start()
    {
        startPosition = transform.position;

        float fullBackgrountWith = GetComponent<BoxCollider>().size.x;
        repeatWidth = fullBackgrountWith / numberOfRepitingFragments;
    }

    void Update()
    {
        if (transform.position.x < startPosition.x - repeatWidth)
        {
            transform.position = startPosition;
        }
    }
}
