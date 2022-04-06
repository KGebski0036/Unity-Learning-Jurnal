using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 20;
    public float rotationSpeed = 30;
    public float verticalInput;
    public float horisontalInput;

    void Start()
    {

    }


    void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        horisontalInput = Input.GetAxis("Horizontal");


        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime * horisontalInput);
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime * verticalInput);
    }
}
