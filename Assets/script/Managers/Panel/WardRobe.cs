using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WardRobe : MonoBehaviour
{
     public static WardRobe instance;
    [SerializeField] GameObject Panel_WardRobe;
    [SerializeField] GameObject Panel_Option;
    private void Awake() 
    {
        instance = this;
    }
   public void Click_ToWardRobe()
    {
        Enable_WardRobePanel();
    }
    public void Click_ToWardRobeF()
    {
        Disable_WardRobePanel();
    }
    void Enable_WardRobePanel() 
    {
           Panel_WardRobe.SetActive(true);
           Panel_Option.SetActive(false);
    }
    void Disable_WardRobePanel()
    {
           Panel_WardRobe.SetActive(false);
           Panel_Option.SetActive(true);
    }
}
