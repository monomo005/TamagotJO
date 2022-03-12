using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weights : MonoBehaviour
{
    public static Weights instance;
    [SerializeField] GameObject Panel_Weights;
    [SerializeField] GameObject Panel_PetUI;
    [SerializeField] GameObject Panel_Exercise;
       [SerializeField] GameObject Panel_Score;
     private void Awake() 
    {
        instance = this;
    }
     void Start() 
    {
    
    }
    public void Update()
    {
        Minigamecontoller.instance.TimeCountDown();
        
    }
   
    public void Click_ToWeights()
    {
        Enable_WeightsPanel(); 
        Disable_ExerciseUIPanel();
        Disable_PetUIPanel();
        Disable_ScoreUIPanel();
       Minigamecontoller.instance.TimeCountDown();
    }
    public void Click_Toback()
    {
        Disable_WeightsPanel(); 
        Enable_PetUIPanel(); 
        Minigamecontoller.instance.resetScore();
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
    void Disable_ExerciseUIPanel()
    {
           Panel_Exercise.SetActive(false);
           
    }
    void Disable_ScoreUIPanel()
    {
           Panel_Score.SetActive(false);
           
    }
}
