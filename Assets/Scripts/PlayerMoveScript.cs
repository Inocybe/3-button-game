using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveScript : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    public float moveSpeed;

    private float _movement;

    private void Update()
    {
        _movement = Input.GetAxis("Vertical") * -1;
    }

    private void FixedUpdate()
    {
        rb.AddForce(0f, 0f, _movement * moveSpeed, ForceMode.Impulse);
    }
}
