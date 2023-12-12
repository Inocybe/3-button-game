using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInventoryScript : MonoBehaviour
{
    public GameObject[] guns;
    [HideInInspector] public int currGun = 0;
    
    private void Start()
    {
        for (int i = 1, len = guns.Length; i < len; i++)
            guns[i].SetActive(false);
    }

    public void Off()
    {
        guns[currGun].SetActive(false);
    }

    public void On()
    {
        guns[currGun].SetActive(true);
    }
}
