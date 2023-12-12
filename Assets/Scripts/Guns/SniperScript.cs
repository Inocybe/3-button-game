using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperScript : MonoBehaviour
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
        //shootObject.Shoot();
    }   
}
