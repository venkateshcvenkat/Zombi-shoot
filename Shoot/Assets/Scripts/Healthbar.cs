using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Healthbar : MonoBehaviour
{
   public Slider slider;


    public void Setmaxhealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
    }
    public void sethealth(float health)
    {
        slider.value = health;
    }
}
