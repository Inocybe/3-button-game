using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyScript : MonoBehaviour
{
    public int bulletHealth = 1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            bulletHealth--;
            if (bulletHealth <= 0 )
                Destroy(gameObject);
        }
    }
}
