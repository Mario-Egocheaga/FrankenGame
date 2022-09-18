using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AISpawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;

    private int randomSpawnZone;
    private float randomXPos, randomYPos;
    private Vector3 spawnPos;

    public EnemyCounter enemyValues;

    private void Start()
    {
        InvokeRepeating("SpawnNewEnemy", 0f, 2f);
        enemyValues.EnemiesKilled = 0;
    }

    private void SpawnNewEnemy()
    {
        randomSpawnZone = Random.Range(0, 4);

        switch (randomSpawnZone)
        {
            case 0:
                randomXPos = Random.Range(-11f, -10f);
                randomYPos = Random.Range(-8f, -8f);
                break;
            case 1:
                randomXPos = Random.Range(-10f, 10f);
                randomYPos = Random.Range(-7f, -8f);
                break;
            case 2:
                randomXPos = Random.Range(10f, 11f);
                randomYPos = Random.Range(-8f, 8f);
                break;
            case 3:
                randomXPos = Random.Range(-10f, -10f);
                randomYPos = Random.Range(-7f, -8f);
                break;
        }

        spawnPos = new Vector3(randomXPos, randomYPos, 0f);
        Instantiate(enemyPrefab[UnityEngine.Random.Range(0, enemyPrefab.Length)], spawnPos, Quaternion.identity);
    }
}
