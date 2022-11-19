using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    public GameObject enemyPrefabs;

    private Vector3 spawnPosition;

    // Screen limits
    private float xRange = 8f;
    private float yRange = 4f;

    // Random values
    private float randomX, randomY;

    // Number of enemies
    private int enemiesCount = 0;

    private void Update()
    {
        // Gets the number of enemies in the scene
        int enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

        // If the number of enemies is less than or equal to 0
        if (enemies <= 0)
        {
            // Increases the number of enemies
            enemiesCount++;

            // Spawns the current number of enemies
            for (int i = 0; i <= enemiesCount; i++)
            {
                SpawnEnemy();
            }
        }
    }

    // Returns a random position in x and y
    public Vector3 RandomPosition()
    {
        randomX = Random.Range(-xRange, xRange);
        randomY = Random.Range(-yRange, yRange);

        return new Vector3(randomX, randomY, 0);
    }

    // Spawns an enemy in a random position
    public void SpawnEnemy()
    {
        spawnPosition = RandomPosition();

        Instantiate(enemyPrefabs, spawnPosition, enemyPrefabs.transform.rotation);
    }
}