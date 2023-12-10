using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float health;
    public float moveSpeed;

    private void Update()
    {
        transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            health--;
            if (health <= 0)
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnDestroy()
    {
        
        
        if (GameObject.FindGameObjectWithTag("WaveSpawner") != null)
        {
            GameObject.FindGameObjectWithTag("WaveSpawner").GetComponent<EnemySpawnScript>().spawnedEnemies.Remove(gameObject);
        }
    }
}
