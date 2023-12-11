using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletScriptableObject", menuName = "ScriptableObjects/bullet")]
public class BulletScriptableObject : ScriptableObject
{
    [SerializeField] public Transform shootPoint;
    public float bulletSpeed;
    public float destroyTimer;

    private GameObject _shootPoint;
}
