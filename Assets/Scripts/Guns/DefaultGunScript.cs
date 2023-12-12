using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultGunScript : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] public BulletScriptableObject shootObject;

    private void Start()
    {
        shootObject.shootPoint = shootPoint;
        shootObject.SetCooldown();
    }

    // Update is called once per frame
    void Update()
    {
        shootObject.ShootCooldown();

        if (Input.GetKeyDown(KeyCode.J))
        {
            GameObject bullet = Instantiate(shootObject.bullet, shootPoint.position, Quaternion.identity);
            Rigidbody rb = bullet.GetComponent<Rigidbody>();
            rb.AddForce(shootObject.bulletSpeed, 0f, 0f, ForceMode.Impulse);
        }
    }
}
