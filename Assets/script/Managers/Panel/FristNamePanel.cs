using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FristNamePanel : MonoBehaviour
{
    [SerializeField] GameObject Panel_PetUI;
    [SerializeField] GameObject Panel_FristUI;
    public void Click_ToFristUI()
    {
        Enable_FristUI();
    }
    public void Click_ToPetUI()
    {
        Disable_FristUI();
    }
    void Enable_FristUI() 
    {

           Panel_PetUI.SetActive(false);
           Panel_FristUI.SetActive(true);
    }
    void Disable_FristUI()
    {
           Panel_PetUI.SetActive(true);
           Panel_FristUI.SetActive(false);
    }
}

