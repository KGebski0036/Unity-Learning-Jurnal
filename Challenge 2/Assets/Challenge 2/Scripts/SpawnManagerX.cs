using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;

    void Start()
    {
        Invoke(nameof(SpawnRandomBall), startDelay);
    }


    void SpawnRandomBall ()
    {
      
        Vector3 randomSpawnPosition = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        int randomBallIndex = Random.Range(0, ballPrefabs.Length);

        Instantiate(
            ballPrefabs[randomBallIndex],
            randomSpawnPosition,
            ballPrefabs[randomBallIndex].transform.rotation);

        Invoke(nameof(SpawnRandomBall), Random.Range(3,5));
    }

}
