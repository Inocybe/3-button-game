using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    public float bulletSpeed;
    
    private float _destroyTime = 3f;
    
    // Start is called before the first frame update
    void Start()
    {
        
        rb.AddForce(bulletSpeed, 0f,0f, ForceMode.Impulse);
    }

    private void Update()
    {
        _destroyTime -= Time.deltaTime;

        if (_destroyTime <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
