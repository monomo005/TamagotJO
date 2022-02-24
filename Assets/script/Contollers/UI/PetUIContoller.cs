using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PetUIContoller : MonoBehaviour
{
    public Image foodImage, happinessImage, energyImage;
    public static PetUIContoller instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else Debug.LogWarning("More than one PetUIContoller in the Scene");
    }
    public void UpdateImages(int food,int happiness,int energy)
    {
        
        foodImage.fillAmount = (float) food / 100;
        happinessImage.fillAmount = (float) happiness / 100;
        energyImage.fillAmount = (float) energy / 100;
    }
}
