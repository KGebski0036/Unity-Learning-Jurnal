using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RorateCamera : MonoBehaviour
{
    float rotationSpeed = 50;
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}
