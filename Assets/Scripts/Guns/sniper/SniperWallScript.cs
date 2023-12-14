using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperWallScript : MonoBehaviour
{
    [SerializeField] public GameObject wall;
    public int maxWalls;

    [HideInInspector] public int currWalls = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            SpawnWall();
        }
    }

    private void SpawnWall()
    {
        if (currWalls < maxWalls)
        {
            Instantiate(wall, transform.position, Quaternion.identity);
            currWalls++;
        }
    }
}
