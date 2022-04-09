using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject obstacle;

    public float startSpawnOffset = 1;
    public float periodicityOfSpawning = 2;

    public Vector3 spawnPosition = new Vector3(30, 0, 0);

    private PlayerControler playerControlerScript;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), startSpawnOffset, periodicityOfSpawning);
        playerControlerScript = GameObject.Find("Player").GetComponent<PlayerControler>();

    }

    // Update is called once per frame
    void Update()
    {
        if(playerControlerScript.isGameOver)
        {
            CancelInvoke();
        }
    }

    void SpawnObstacle()
    {
        Instantiate(obstacle, spawnPosition, obstacle.transform.rotation);
    }
}
