using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise01 : MonoBehaviour
{
    public GameObject enemyPrefabs;

    private Vector3 spawnPosition;

    private float xRange = 8f;
    private float yRange = 4f;

    private float randomX, randomY;

    private int index = 0;

    private void Update()
    {
        int enemies = GameObject.FindGameObjectsWithTag("Enemy").Length;

        if (enemies <= 0)
        {
            index++;

            for (int i = 0; i <= index; i++)
            {
                SpawnEnemy();
            }
        }
    }

    public Vector3 RandomPosition()
    {
        randomX = Random.Range(-xRange, xRange);
        randomY = Random.Range(-yRange, yRange);

        return new Vector3(randomX, randomY, 0);
    }

    public void SpawnEnemy()
    {
        spawnPosition = RandomPosition();

        Instantiate(enemyPrefabs, spawnPosition, enemyPrefabs.transform.rotation);
    }
}