using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class colorbar : MonoBehaviour
{
 public Slider Slider;
 public Gradient gradient;
 public Image fill;
void Start()
    {
        
    }

 public void SetmaxHealth(int health)
 {
     Slider.maxValue = health;
     Slider.value = health;
     fill.color = gradient.Evaluate(1f);
 }
 public void SetHealth(int Health)
 {
     Slider.value = Health;
     fill.color = gradient.Evaluate(Slider.normalizedValue);
 }
}
