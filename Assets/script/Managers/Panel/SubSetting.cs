using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubSetting : MonoBehaviour
{
     public static SubSetting instance;
    [SerializeField] GameObject Panel_SettingZ;
    [SerializeField] GameObject Panel_Option;
    private void Awake() 
    {
        instance = this;
    }
   public void Click_ToSettingz()
    {
        Enable_SettingPanel();
    }
    public void Click_ToSettingzF()
    {
        Disable_SettingPanel();
    }
    void Enable_SettingPanel() 
    {
           Panel_SettingZ.SetActive(true);
           Panel_Option.SetActive(false);
    }
    void Disable_SettingPanel()
    {
           Panel_SettingZ.SetActive(false);
           Panel_Option.SetActive(true);
    }
}
