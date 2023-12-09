using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawnScript : MonoBehaviour
{
    public List<Enemy> enemies = new List<Enemy>();
    public int currentWave;
    public int waveValue;
    public List<GameObject> enemiesToSpawn = new List<GameObject>();
    
    // will store values of random locations for enemy to spawn
    private const float _xPos = 14.5f;
    private float _zPos;
    public int waveDuration;
    private float _waveTimer;
    private float _spawnInterval;
    private float _spawnTimer;
    
    public List<GameObject> spawnedEnemies = new List<GameObject>();
    public int timeBetweenWaves;
    
    private void Start()
    {
        GenerateWave();
    }

    private void FixedUpdate()
    {
        if (_spawnTimer <= 0)
        {
            //spawn enemy
            if (enemiesToSpawn.Count > 0)
            {
                GameObject enemy = Instantiate(enemiesToSpawn[0], new Vector3(_xPos, 1.5f, Random.Range(-14.5f, 14.5f)),
                    Quaternion.identity); //spawn first enemy in list
                enemiesToSpawn.RemoveAt(0); // remove enemy from list
                spawnedEnemies.Add(enemy);
                _spawnTimer = _spawnInterval;
            }
            else
            {
                _waveTimer = 0; //if no enemies remain, end wave
            }
        }
        else
        {
            _spawnTimer -= Time.deltaTime;
            _waveTimer -= Time.deltaTime;
        }

        if (_waveTimer <= 0 && spawnedEnemies.Count <= 0)
        {
            currentWave++;
            StartCoroutine(WaveSpawnBreak());
        }
    }

    private void GenerateWave()
    {
        waveValue = currentWave * 10;
        GenerateEnemies();

        _spawnInterval = waveDuration / enemiesToSpawn.Count; //makes fixed time between enemies
        _waveTimer = waveDuration;
    }

    private void GenerateEnemies()
    {
        // creates temp list of enemies to generate
        // pick random enemy, then see if we can use it
        // if can, add to list

        List<GameObject> generatedEnemies = new List<GameObject>();

        while (waveValue > 0)
        {
            int randEnemyInt = Random.Range(0, enemies.Count);
            int randEnemyCost = enemies[randEnemyInt].cost;

            if (waveValue - randEnemyCost >= 0)
            {
                generatedEnemies.Add(enemies[randEnemyInt].enemyPrefab);
                waveValue -= randEnemyCost;
            }
            else if (waveValue <= 0)
            {
                break;
            }
        }

        enemiesToSpawn.Clear();
        enemiesToSpawn = generatedEnemies;
    }

    IEnumerator WaveSpawnBreak()
    {
        yield return new WaitForSeconds(timeBetweenWaves);
        GenerateWave();
    }

}

[System.Serializable]
public class Enemy
{
    public GameObject enemyPrefab;
    public int cost;
}


