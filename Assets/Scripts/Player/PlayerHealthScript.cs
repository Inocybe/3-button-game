using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealthScript : MonoBehaviour
{
    public Slider slider;
    public int startHealth;

    [HideInInspector] public int health;
    private void Start()
    {
        health = startHealth; 
        slider.maxValue = health;
        slider.value = health;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            health--;
            slider.value = health;
            if (health == 0)
                Death();

        }
    }

    private void Death()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
