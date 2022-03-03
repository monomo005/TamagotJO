using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Running : MonoBehaviour
{
    public static Running instance;
    [SerializeField] GameObject Panel_Running;
    [SerializeField] GameObject Panel_PetUI;
    [SerializeField] GameObject Panel_Exercise;
     private void Awake() 
    {
        instance = this;
    }
     void Start() 
    {
    
    }
   
    public void Click_ToRunning()
    {
        Enable_RunningPanel(); 
        Disable_PetUIPanel();
    }
    public void Click_Toback()
    {
        Disable_RunningPanel(); 
        Enable_PetUIPanel(); 
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
    void Disable_PetUIPanel()
    {
           Panel_PetUI.SetActive(false);
           
    }
}
