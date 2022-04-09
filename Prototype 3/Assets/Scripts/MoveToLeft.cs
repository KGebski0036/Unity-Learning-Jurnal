using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToLeft : MonoBehaviour
{
    private float speed = 10;
    private PlayerControler playerControlerScript;
    void Start()
    {
        playerControlerScript = GameObject.Find("Player").GetComponent<PlayerControler>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!playerControlerScript.isGameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
