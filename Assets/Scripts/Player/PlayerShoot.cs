using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootPoint;

    public float shootCooldown;

    private float _originalShootCooldown;

    private void Start()
    {
        _originalShootCooldown = shootCooldown;
    }

    // Update is called once per frame
    void Update()
    {
        shootCooldown -= Time.deltaTime;

        if (shootCooldown <= 0)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
       if (Input.GetKeyDown(KeyCode.J))
       {
           GameObject instantiatedBullet = Instantiate(bullet, shootPoint.position, Quaternion.identity); 
           //instantiatedBullet.transform.position = shootPoint.position;
           shootCooldown = _originalShootCooldown;
       }
    }
}
