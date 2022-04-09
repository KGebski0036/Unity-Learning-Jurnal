using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;

    public float startSpawnOffset = 3;
    public float periodicityOfSpawning = 2;

    public Vector3 spawnPosition = new Vector3(20, 0, 0); 
    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), startSpawnOffset, periodicityOfSpawning);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle()
    {
        Instantiate(obstacle, spawnPosition, obstacle.transform.rotation);
    }
}
