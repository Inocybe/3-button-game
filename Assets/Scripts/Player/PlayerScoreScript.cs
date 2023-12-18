using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class SliderScript : MonoBehaviour
{
    public SliderInt slider;
    
    public void SetMaxHealth(int health)
    {
        slider.highValue = health;
        slider.value = health;

    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }
}
