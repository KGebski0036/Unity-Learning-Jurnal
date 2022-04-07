using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float spawnDogCooldownInSec = 1f;
    private float currentSpawnCooldown = 0;

    // Update is called once per frame
    void Update()
    {
        if (currentSpawnCooldown > 0)
        {
            currentSpawnCooldown -= Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space) && currentSpawnCooldown <= 0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            currentSpawnCooldown = spawnDogCooldownInSec;
        }
    }
}
