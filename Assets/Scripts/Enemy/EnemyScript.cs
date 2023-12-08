using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float moveSpeed;

    private void Update()
    {
        transform.position += new Vector3(-moveSpeed * Time.deltaTime, 0, 0);
    }
}
