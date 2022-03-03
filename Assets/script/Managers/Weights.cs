using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weights : MonoBehaviour
{
    public static Weights instance;
    [SerializeField] GameObject Panel_Weights;
    [SerializeField] GameObject Panel_PetUI;
    [SerializeField] GameObject Panel_Exercise;

     private void Awake() 
    {
        instance = this;
    }
     void Start() 
    {
    
    }
   
    public void Click_ToWeights()
    {
        Enable_WeightsPanel(); 
        Disable_PetUIPanel();
    }
    public void Click_Toback()
    {
        Disable_WeightsPanel(); 
        Enable_PetUIPanel(); 
    }
    void Enable_WeightsPanel() 
    {
           Panel_Weights.SetActive(true);
           
    }
    void Disable_WeightsPanel()
    {
           Panel_Weights.SetActive(false);
           
    }
       void Enable_PetUIPanel() 
    {
           Panel_PetUI.SetActive(true);
           
    }
    void Disable_PetUIPanel()
    {
           Panel_PetUI.SetActive(false);
           
    }
}
