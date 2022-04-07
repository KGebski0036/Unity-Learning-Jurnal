using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMenagerScript : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float maxSpawnRangeX = 24;
    private float minSpawnRangeX = -24;
    private float SpawnRangeY = 30;

    private float spawnDelay = 2;
    private float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnInterval);
    }

    void Update()
    {

    }

    private void SpawnRandomAnimal()
    {
        int randomAnimalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 randomAnimalSpawn = new Vector3(Random.Range(minSpawnRangeX, maxSpawnRangeX), 0, SpawnRangeY);
        Instantiate(
            animalPrefabs[randomAnimalIndex],
            randomAnimalSpawn,
            animalPrefabs[randomAnimalIndex].transform.rotation
            );
    }
}
