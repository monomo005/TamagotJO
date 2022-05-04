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
    public void Click_Toback()
    {
        Disable_ShopPanel();
        Enable_OptionPanel();
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
}
