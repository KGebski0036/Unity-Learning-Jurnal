using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] objectPrefabs;

    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;

    private PlayerControllerX playerControllerScript;

    void Start()
    {
        InvokeRepeating(nameof(SpawnObjects), spawnDelay, spawnInterval);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerControllerX>();
    }
    private void Update()
    {
        if (playerControllerScript.gameOver)
        {
            CancelInvoke();
        }
    }

    void SpawnObjects ()
    {
        int index = Random.Range(0, objectPrefabs.Length);
        Vector3 spawnLocation = new Vector3(30, Random.Range(5, 15), 0);

        Instantiate(objectPrefabs[index], spawnLocation, objectPrefabs[index].transform.rotation);

    }
}
