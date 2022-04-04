using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{
    public Vector3 transformVector;
    void Start()
    {

    }

    
    void Update()
    {
        transform.localScale += transformVector * Time.deltaTime;
    }
}
