using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // Assign your enemy prefab in the inspector
    public float spawnDelay = 2.0f; // Time delay between spawns

    private float nextSpawnTime;

    void Update()
    {
        // If the current time is greater than nextSpawnTime
        if (Time.time > nextSpawnTime)
        {
            // Instantiate an enemy at the spawner's position
            Instantiate(enemyPrefab, transform.position, Quaternion.identity);

            // Set the next spawn time
            nextSpawnTime = Time.time + spawnDelay;
        }
    }
}