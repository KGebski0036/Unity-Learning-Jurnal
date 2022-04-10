using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 80;
    private Rigidbody rigidbody;
    private GameObject player;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        Vector3 vectorToPlayerLocation = (player.transform.position - transform.position).normalized;
        rigidbody.AddForce(vectorToPlayerLocation * speed * Time.deltaTime);
    }
}
