using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AKscript : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;
    [SerializeField] public BulletScriptableObject shootObject;

    public float spread;

    private void Start()
    {
        shootObject.shootPoint = shootPoint;
        shootObject.SetCooldown();
    }

    // Update is called once per frame
    void Update()
    {
        shootObject.ShootCooldown();

        if (Input.GetKey(KeyCode.J) && shootObject._shootCooldown <= 0f)
        {
            float zForce = Random.Range(-spread, spread);
            float xForce = shootObject.bulletSpeed - zForce;

            GameObject bullet = Instantiate(shootObject.bullet, shootPoint.position, Quaternion.identity);
            bullet.GetComponent<Rigidbody>().AddForce(xForce, 0f, zForce, ForceMode.Impulse);
            shootObject._shootCooldown = shootObject.shootCooldown;
        }
    }
}
