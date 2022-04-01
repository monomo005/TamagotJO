using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ExpStat : MonoBehaviour
{
   
    public static ExpStat instance;
    public int PetExp = 0;
    public int nextEXPtoLevelUp = 100;
    [SerializeField] GameObject Panel_PetEvolution;
     [SerializeField] int given100Topaz = 100;
     [SerializeField] Image ExpValueUI;
     [SerializeField] Text ExpTextValue;
     float targetEXPRatioToSet = 1.0f;

    public GameObject Star1;
    public GameObject Star2;
    public GameObject Star3;
    private void Awake() 
    {
        instance = this;
    }
    void Start() 
    {
        Panel_PetEvolution.SetActive(false);   
        Star1.SetActive(true);
        Star2.SetActive(false);
        Star3.SetActive(false);
    }
    void Update()
    {
        Update_PetExpInterface();
        
    }
    void Enable_EvolutionPanel() 
    {
           Panel_PetEvolution.SetActive(true);
           Time.timeScale = 0; //หยุดจอเพื่อเปลี่ยนร่าง
    }
    void Disable_EvolutionPanel()
    {
           Panel_PetEvolution.SetActive(false);
           Time.timeScale = 1; //เริ่มเล่นต่อ
    }
    public void Click_ToCon()
    {
        Disable_EvolutionPanel();
    }
    public void Update_PetEXP(int expAmount)
    {
        PetExp += expAmount;
        if(PetExp>= nextEXPtoLevelUp)
        {
            PetExp = PetExp - nextEXPtoLevelUp;
            nextEXPtoLevelUp += 100;

            if(nextEXPtoLevelUp >=200)
            {
                Star2.SetActive(true);
            }
            if(nextEXPtoLevelUp >=300)
            {
                Star3.SetActive(true);
            }
            
             Enable_EvolutionPanel();
            Topaz.instance.Update_Topas(given100Topaz);
        }
    }
    void Update_PetExpInterface()
    {
        ExpTextValue.text = ExpStat.instance.PetExp + "/" + ExpStat.instance.nextEXPtoLevelUp;
        targetEXPRatioToSet = ExpStat.instance.PetExp *1.0f / ExpStat.instance.nextEXPtoLevelUp;

        float currentFillAmount_EXP = ExpValueUI.fillAmount;
        ExpValueUI.fillAmount = Mathf.Lerp(currentFillAmount_EXP, targetEXPRatioToSet, 0.05f);
    }
}