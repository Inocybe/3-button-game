using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDestroy : MonoBehaviour
{
    public float aliveTime;

    private void FixedUpdate()
    {
        aliveTime -= Time.deltaTime;
        
        if (aliveTime <= 0f)
            Destroy(gameObject);
    }

    private void OnDestroy()
    {
        if (GameObject.FindGameObjectWithTag("Sniper") != null)
        {
            GameObject.FindGameObjectWithTag("Sniper").GetComponent<SniperWallScript>().currWalls--;
        }
    }
}
