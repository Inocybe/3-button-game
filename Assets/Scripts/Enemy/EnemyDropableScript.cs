using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyDropableScript : MonoBehaviour
{
    public Material[] drops;

    private Renderer _rend;
    private int _theDrop;
    private float _iFrames = 0.5f;
    
    private void Start()
    {
        _rend = GetComponent<Renderer>();
        _rend.enabled = true;
        _theDrop = Random.Range(0, drops.Length);

        _rend.sharedMaterial = drops[_theDrop];
    }

    private void Update()
    {
        _iFrames -= Time.deltaTime;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet") && _iFrames <= 0)
        {
            Destroy(gameObject);
        }
    }
}
