using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Setting : MonoBehaviour
{
    public static Setting instance;
    [SerializeField] GameObject Panel_Setting;
    [SerializeField] GameObject Panel_Main;
    private void Awake() 
    {
        instance = this;
    }
    void Start()
    {
        
    }
public void Click_ToOption()
    {
        Enable_SettingPanel();
    }
    public void Click_ToOptionF()
    {
        Disable_SettingPanel();
    }
    void Enable_SettingPanel() 
    {
           Panel_Setting.SetActive(true);
           Panel_Main.SetActive(false);
    }
    void Disable_SettingPanel()
    {
           Panel_Setting.SetActive(false);
           Panel_Main.SetActive(true);
    }
}
