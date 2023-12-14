using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RPGexplosion : MonoBehaviour
{
    [SerializeField] private GameObject explosion;

    private void OnDestroy()
    {
        // create gameObject that will damage enemies inside
        Instantiate(explosion, transform.position, Quaternion.identity);
    }
}
