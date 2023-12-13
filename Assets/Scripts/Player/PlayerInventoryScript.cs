using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInventoryScript : MonoBehaviour
{
    public int startingGun;
    
    public GameObject[] guns;
    [HideInInspector] public int currGun;
    
    private void Start()
    {
        guns[startingGun].SetActive(true);
        currGun = startingGun;
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
