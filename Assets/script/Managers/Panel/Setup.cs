using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setup : MonoBehaviour
{
     public static Setup instance;
    [SerializeField] GameObject Panel_Setup;
    [SerializeField] GameObject Panel_Option;

   private void Awake() 
    {
        instance = this;
    }
    public void Click_ToSetup()
    {
        Enable_SetPanel();
    }
    public void Click_ToSetupF()
    {
        Disable_SetPanel();
    }
    void Enable_SetPanel() 
    {
           Panel_Setup.SetActive(true);
           Panel_Option.SetActive(false);
    }
    void Disable_SetPanel()
    {
           Panel_Setup.SetActive(false);
           Panel_Option.SetActive(true);
    }
}
