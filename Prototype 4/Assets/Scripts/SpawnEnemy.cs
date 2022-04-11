using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemyPrefab;
    public GameObject powerupPrefab;

    private float mapSize = 9;

    private int countEnemy;
    private int enemyInNextWave = 2;

    private void Update()
    {
        countEnemy = FindObjectsOfType<Enemy>().Length;

        if (countEnemy <= 0)
        {
            SpawnWave(enemyInNextWave);
            enemyInNextWave++;
        }
    }

    private void SpawnWave(int numberOfEnemys)
    {
        for (int i = 0; i < numberOfEnemys; i++)
        {
            SpawnRandomEnemy(RandomPosition());
            if (i % 3 == 1)
            {
                SpawnRandomPowerUp(RandomPosition());
            }
        }
    }

    private void SpawnRandomPowerUp(Vector3 randomPosition)
    {
        Instantiate(powerupPrefab, randomPosition, enemyPrefab.transform.rotation);
    }

    private void SpawnRandomEnemy(Vector3 randomPosition)
    {
        Instantiate(enemyPrefab, randomPosition, enemyPrefab.transform.rotation);
    }

    Vector3 RandomPosition()
    {
        float randomValueX = Random.Range(-mapSize, mapSize);
        float randomValueZ = Random.Range(-mapSize, mapSize);

        return new Vector3(randomValueX, 0, randomValueZ);
    }
}
