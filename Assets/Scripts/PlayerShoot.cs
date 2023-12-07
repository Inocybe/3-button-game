using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform shootPoint;

    public float shootCooldown;
    public float bulletSpeed;

    private float originalShootCooldown;

    private void Start()
    {
        originalShootCooldown = shootCooldown;
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
            GameObject instantiatedBullet = Instantiate(bullet);
            instantiatedBullet.transform.position = shootPoint.position;
            instantiatedBullet.GetComponent<Rigidbody>().velocity = new Vector3(bulletSpeed, 0f, 0f);
            shootCooldown = originalShootCooldown;
       }
    }
}
