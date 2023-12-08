using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    [SerializeField] private GameObject enemy;
    
    public float enemySpawnCoolDown;
    public int enemiesPerWave;
    
    
    
    // will store values of random locations for enemy to spawn
    private float _xPos = 14.5f;
    private float _zPos;

    // variable to just count how many enemies are spawned
    private int _enemyCount;
    
    
    private int _waveNumber = 1;
    
    void Start()
    {
        StartCoroutine(EnemySpawning());
    }
    
    IEnumerator EnemySpawning()
    {
        while (_enemyCount < enemiesPerWave)
        {
            _zPos = Random.Range(-14.5f, 14.5f);
            Instantiate(enemy, new Vector3(_xPos, 1.5f, _zPos),Quaternion.identity);
            yield return new WaitForSeconds(enemySpawnCoolDown);
            _enemyCount++;
        }
    }
}
