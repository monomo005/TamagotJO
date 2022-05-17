using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTopaz : MonoBehaviour
{
    public static ShopTopaz instance;
    [SerializeField] GameObject Panel_shop;
    [SerializeField] GameObject Panel_ShopTopaz;
    [SerializeField] GameObject Panel_Energy;
    [SerializeField] GameObject Panel_PetUI;
    [SerializeField] GameObject Panel_Backend1;
    [SerializeField] GameObject Panel_Backend2;
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
        Disable_Backend1();
        
    }
    public void Click_ToShopTopazInput()
    {
        Enable_ShopTopazPanel(); //เปิดร้านเฟอร์นิเจอร์
        Enable_Backend1();
        Disable_EnergyPanel();
        
    }
    public void Click_Toback()
    {
        Disable_ShopTopazPanel(); //ปิดร้านเฟอร์นิเจอร์
        Disable_EnergyPanel();
        Enable_ShopPanel(); //เปิดช้อป
    }
    public void Click_TobackPetUI()
    {
        Disable_ShopTopazPanel(); //ปิดร้านเฟอร์นิเจอร์
        Disable_EnergyPanel();
        Enable_PetUIPanel(); //เปิดช้อป
    }
    public void Click_ToShopEnergy()
    {
           Enable_EnergyPanel();
           Disable_ShopTopazPanel();
           Disable_ShopPanel(); //ปิดช้อป
           Disable_Backend2();
    }
     public void Click_ToShopEnergyUI()
    {
           Enable_EnergyPanel();
            Enable_Backend2();
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
    void Enable_PetUIPanel()
    {
           Panel_PetUI.SetActive(true);
    }
    void Enable_Backend1()
    {
           Panel_Backend1.SetActive(true);
    }
    void Disable_Backend1()
    {
           Panel_Backend1.SetActive(false);
    }
    void Enable_Backend2()
    {
           Panel_Backend2.SetActive(true);
    }
    void Disable_Backend2()
    {
           Panel_Backend2.SetActive(false);
    }
}
