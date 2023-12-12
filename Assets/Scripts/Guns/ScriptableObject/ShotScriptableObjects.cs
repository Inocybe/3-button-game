using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletScriptableObject", menuName = "ScriptableObjects/bullet")]
public class BulletScriptableObject : ScriptableObject
{
    [SerializeField] public GameObject bullet;
    [HideInInspector] public Transform shootPoint;
    public float bulletSpeed;
    public float shootCooldown;

    private float _shootCooldown;

    public void SetCooldown()
    {
        _shootCooldown = shootCooldown;
    }

    private GameObject _shotBullet;
    
    public void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.J) && _shootCooldown <= 0)
        {
            _shotBullet = Instantiate(bullet, shootPoint.transform.position, Quaternion.identity); 
            Rigidbody rb = _shotBullet.GetComponent<Rigidbody>();
            rb.AddForce(bulletSpeed, 0f, 0f, ForceMode.Impulse);
            
            _shootCooldown = shootCooldown;
        }
        _shootCooldown -= Time.deltaTime;
    }
}
