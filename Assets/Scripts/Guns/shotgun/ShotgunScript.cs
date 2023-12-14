using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class ShotgunScript : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] public BulletScriptableObject shootObject;

    public float spread;
    public int bulletCount;

    private void Start()
    {
        shootObject.shootPoint = shootPoint;
        shootObject.SetCooldown();
    }

    private void Update()
    {
        shootObject.ShootCooldown();

        if (Input.GetKeyDown(KeyCode.J) && shootObject._shootCooldown <= 0f)
        {
            Vector3 position = shootPoint.position;

            for (int i = 0, count = bulletCount; i < count; i++)
            {
                //this shall go through each i iteration for amount of bullets shotgun has, and will basically do normal stuff
                float zForce = Random.Range(-spread, spread);
                float xForce = shootObject.bulletSpeed - Math.Abs(zForce);

                GameObject bullet = Instantiate(shootObject.bullet, shootPoint.position, Quaternion.identity);
                bullet.GetComponent<Rigidbody>().AddForce(xForce, 0f, zForce, ForceMode.Impulse);
                
                shootObject._shootCooldown = shootObject.shootCooldown;
            }
        }
    }
}
