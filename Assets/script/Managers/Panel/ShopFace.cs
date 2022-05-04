using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopFace : MonoBehaviour
{
    public static ShopFace instance;
    [SerializeField] GameObject Panel_ShopFace;
    [SerializeField] GameObject Panel_PetUI;
    private void Awake() 
    {
        instance = this;
    }
   public void Click_ToShopFace()
    {
        Enable_ShopFacePanel();
    }
    public void Click_ToShopFaceF()
    {
        Disable_ShopFacePanel();
    }
    void Enable_ShopFacePanel() 
    {
           Panel_ShopFace.SetActive(true);
           Panel_PetUI.SetActive(false);
    }
    void Disable_ShopFacePanel()
    {
           Panel_ShopFace.SetActive(false);
           Panel_PetUI.SetActive(true);
    }
}
