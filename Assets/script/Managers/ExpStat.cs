using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ExpStat : MonoBehaviour
{
   
    public static ExpStat instance;
    public int PetExp = 0;
    public int nextEXPtoLevelUp = 100;
    [SerializeField] GameObject Panel_PetEvolution;

    private void Awake() 
    {
        instance = this;
    }
    void Start() 
    {
        Panel_PetEvolution.SetActive(false);   
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

             Enable_EvolutionPanel();
        }

    }
}
