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
    
    public void ShootCooldown()
    {
        _shootCooldown -= Time.deltaTime;
    }
}
