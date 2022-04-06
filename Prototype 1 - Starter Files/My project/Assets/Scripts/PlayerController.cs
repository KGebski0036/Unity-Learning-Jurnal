using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Animations;

public class PlayerController : MonoBehaviour
{
    public float speed = 60;
    public float Turnspeed = 20;

    public float horisontalInput;
    public float forewardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horisontalInput = Input.GetAxis("Horizontal");
        forewardInput = Input.GetAxis("Vertical");
       
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forewardInput);
        transform.Rotate(Vector3.up, Time.deltaTime * Turnspeed * horisontalInput);
    }
}
