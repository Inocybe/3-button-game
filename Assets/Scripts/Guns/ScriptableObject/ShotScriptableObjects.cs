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

    [HideInInspector] public float _shootCooldown;

    public void SetCooldown()
    {
        _shootCooldown = shootCooldown;
    }
    
    public void ShootCooldown()
    {
        _shootCooldown -= Time.deltaTime;
    }
}
