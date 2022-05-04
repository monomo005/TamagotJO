using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTopaz : MonoBehaviour
{
    public static ShopTopaz instance;
    [SerializeField] GameObject Panel_shop;
    [SerializeField] GameObject Panel_ShopTopaz;
    [SerializeField] GameObject Panel_Energy;
     private void Awake() 
    {
        instance = this;
    }
     void Start() 
    {
    
    }
   
    public void Click_ToShopTopaz()
    {
        Enable_ShopTopazPanel(); //เปิดร้านเฟอร์นิเจอร์
        Disable_ShopPanel(); //ปิดช้อป
        Disable_EnergyPanel();
        
    }
    public void Click_Toback()
    {
        Disable_ShopTopazPanel(); //ปิดร้านเฟอร์นิเจอร์
        Disable_EnergyPanel();
        Enable_ShopPanel(); //เปิดช้อป
    }
    public void Click_ToShopEnergy()
    {
           Enable_EnergyPanel();
           Disable_ShopTopazPanel();
           Disable_ShopPanel(); //ปิดช้อป
    }
    void Enable_ShopTopazPanel() 
    {
           Panel_ShopTopaz.SetActive(true);
    }
    void Disable_ShopTopazPanel()
    {
           Panel_ShopTopaz.SetActive(false);  
    }
    void Enable_ShopPanel() 
    {
           Panel_shop.SetActive(true);
    }
    void Disable_ShopPanel()
    {
           Panel_shop.SetActive(false);
    }
    void Enable_EnergyPanel() 
    {
           Panel_Energy.SetActive(true);
    }
    void Disable_EnergyPanel()
    {
           Panel_Energy.SetActive(false);
    }
}
