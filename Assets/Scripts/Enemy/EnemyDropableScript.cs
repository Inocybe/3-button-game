using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyDropableScript : MonoBehaviour
{
    private PlayerInventoryScript inventory;
    public Material[] drops;

    private Renderer _rend;
    [HideInInspector] public int theDrop;
    private float _iFrames = 0.5f;
    
    private void Start()
    {
        _rend = GetComponent<Renderer>();
        _rend.enabled = true;
        theDrop = Random.Range(0, drops.Length);

        _rend.sharedMaterial = drops[theDrop];

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerInventoryScript>();
    }

    private void Update()
    {
        _iFrames -= Time.deltaTime;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bullet") && _iFrames <= 0)
        {
            inventory.Off();
            inventory.currGun = theDrop;
            inventory.On();
            Destroy(gameObject);
        }
    }
}
