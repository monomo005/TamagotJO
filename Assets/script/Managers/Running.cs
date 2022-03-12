using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{
    public static Running instance;
    [SerializeField] GameObject Panel_Running;
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
   
    public void Click_ToRunning()
    {
        Enable_RunningPanel();
        Disable_ExerciseUIPanel();
        Disable_PetUIPanel();
        Disable_ScoreUIPanel();
        Minigamecontoller.instance.TimeCountDown();
    }
    public void Click_Toback()
    {
        Disable_RunningPanel();
        Enable_PetUIPanel(); 
        Minigamecontoller.instance.resetScore();
    }
    void Enable_RunningPanel() 
    {
           Panel_Running.SetActive(true);
           
    }
    void Disable_RunningPanel()
    {
           Panel_Running.SetActive(false);
           
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
