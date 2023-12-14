using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private GameObject dropAble;

    public int dropChange;
    public int health;
    public float moveSpeed;

    private void FixedUpdate()
    {
        transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet"))
        {
            health--;
            Death();
        }

        if (other.gameObject.CompareTag("Explosion"))
        {
            health -= 2;
            Death();
        }
    }

    private void Death()
    {
        if (health <= 0)
        {
            int drop = Random.Range(0, dropChange);
        
            if (drop == 0)
                Instantiate(dropAble, gameObject.transform.position, Quaternion.identity);
                
            Destroy(gameObject);
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
