using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float mapSize = 9;
    void Start()
    {
        SpawnRandomEnemy();
    }

    void SpawnRandomEnemy()
    {
        float randomValueX = Random.Range(-mapSize, mapSize);
        float randomValueZ = Random.Range(-mapSize, mapSize);

        Vector3 randomPosition = new Vector3(randomValueX, 0, randomValueZ);
        Instantiate(enemyPrefab, randomPosition, enemyPrefab.transform.rotation);
    }
}
