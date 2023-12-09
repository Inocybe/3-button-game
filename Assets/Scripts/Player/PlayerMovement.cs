using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rb;

    public float moveSpeed;

    private float _move;

    
    // Start is called before the first frame update
    void Update()
    {
        _move = Input.GetAxis("Vertical");

        if (_move == 0)
        {
            rb.velocity = Vector3.zero;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0f, 0f, _move * moveSpeed, ForceMode.Impulse);
    }
}
