using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    private float horisontalInput = 0;
    private float playerSpeed = 15;
    private float maxRangeX = 24;

    public GameObject bulletPrefab;
    void Start()
    {
        
    }

    void Update()
    {
        horisontalInput = Input.GetAxis("Horizontal");
        
        transform.Translate(Vector3.right * horisontalInput * Time.deltaTime * playerSpeed);

        CheckMaxRangeForX();
        CheckForSchooting();
    }
    void CheckMaxRangeForX()
    {
        if (transform.position.x > maxRangeX)
        {
            transform.position = new Vector3(maxRangeX, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -maxRangeX)
        {
            transform.position = new Vector3(-maxRangeX, transform.position.y, transform.position.z);
        }
    }
    void CheckForSchooting()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bulletPrefab, transform.position, transform.rotation);
        }
    }
}
