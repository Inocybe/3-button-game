using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionScript : MonoBehaviour
{
    [SerializeField] public SphereCollider sCollider;
    public float maxSize;
    public float duration;

    private float _startDuration;
    private float _increaseAmount;

    private void Start()
    {
        _increaseAmount = maxSize / duration;
        _startDuration = duration;
    }
    
    private void FixedUpdate()
    {
        TransformIncrease();
        ColliderIncrease();
        duration -= Time.deltaTime;

        if (duration <= 0f)
        {
            Destroy(gameObject);
        }
    }

    private void TransformIncrease()
    {
        if (duration >= _startDuration / 2f)
            transform.localScale += new Vector3(_increaseAmount, _increaseAmount,_increaseAmount);
    }

    private void ColliderIncrease()
    {
        if (duration >= _startDuration / 2f)
            sCollider.radius += _increaseAmount / 50f;
    }
}
