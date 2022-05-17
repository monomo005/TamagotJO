using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    public static Shop instance;
    [SerializeField] GameObject Panel_shop;
    [SerializeField] GameObject Panel_shopfuniture;
    [SerializeField] GameObject Panel_shopfashion;
    [SerializeField] GameObject Panel_shopTopaz;
    [SerializeField] GameObject Panel_OptionUI;
    [SerializeField] GameObject Panel_PetUI;
    [SerializeField] GameObject Panel_backendUI;
     private void Awake() 
    {
        instance = this;
    }
     void Start() 
    {
    
    }
    public void Click_ToShop()
    {
        Enable_ShopPanel();
        Disable_OptionPanel();
        
    }
    public void Click_ToShopInput()
    {
        Enable_ShopPanel();
        Disable_PetUIPanel();
        Enable_backendPanel();
    }
    
    public void Click_Toback()
    {
        Disable_ShopPanel();
        Enable_OptionPanel();
    }
    public void Click_TobackInput()
    {
        Disable_ShopPanel();
        Disable_backendPanel();
        Enable_PetUIPanel();
    }
    void Enable_ShopPanel() 
    {
           Panel_shop.SetActive(true);
           Time.timeScale = 0; //หยุดจอเพื่อเปลี่ยนร่าง
    }
    void Disable_ShopPanel()
    {
           Panel_shop.SetActive(false);
           Time.timeScale = 1; //เริ่มเล่นต่อ
    }
    void Enable_OptionPanel() 
    {
           Panel_OptionUI.SetActive(true);
           
    }
    void Disable_OptionPanel()
    {
           Panel_OptionUI.SetActive(false);
           
    }
     void Enable_PetUIPanel() 
    {
           Panel_PetUI.SetActive(true);
           
    }
    void Disable_PetUIPanel()
    {
           Panel_PetUI.SetActive(false);
           
    }
    void Disable_backendPanel()
    {
           Panel_backendUI.SetActive(false);
           
    }
    void Enable_backendPanel()
    {
           Panel_backendUI.SetActive(true);
           
    }
}
