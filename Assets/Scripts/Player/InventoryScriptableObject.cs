using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[CreateAssetMenu(fileName = "InventoryScriptableObject", menuName = "ScriptableObjects/Inventory")]
public class InventoryScriptableObject : ScriptableObject
{
    [SerializeField] public GameObject[] guns;

    [HideInInspector] public int currGun;
    
    public void SwitchWeapon()
    {
        
    }
}
