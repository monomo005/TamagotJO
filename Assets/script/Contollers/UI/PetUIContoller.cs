using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PetUIContoller : MonoBehaviour
{
    public Image foodImage, happinessImage, energyImage;
    public static PetUIContoller instance;
    [SerializeField] Image ExpValueUI;
    [SerializeField] Text ExpTextValue;
    
    
    float targetEXPRatioToSet = 1.0f;
    
    

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
    void Update()
    {
        Update_PetExpInterface();


    }
    void Update_PetExpInterface()
    {
        ExpTextValue.text = ExpStat.instance.PetExp + "/" + ExpStat.instance.nextEXPtoLevelUp;
        targetEXPRatioToSet = ExpStat.instance.PetExp *1.0f / ExpStat.instance.nextEXPtoLevelUp;

        float currentFillAmount_EXP = ExpValueUI.fillAmount;
        ExpValueUI.fillAmount = Mathf.Lerp(currentFillAmount_EXP, targetEXPRatioToSet, 0.05f);
    }
  
}
