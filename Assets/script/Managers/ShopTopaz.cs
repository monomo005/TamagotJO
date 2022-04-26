using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopTopaz : MonoBehaviour
{
    public static ShopTopaz instance;
    [SerializeField] GameObject Panel_shop;
    [SerializeField] GameObject Panel_ShopTopaz;
    [SerializeField] GameObject Panel_PetUI;
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
        Disable_PetPanel();
    }
    public void Click_Toback()
    {
        Disable_ShopTopazPanel(); //ปิดร้านเฟอร์นิเจอร์
        Enable_ShopPanel(); //เปิดช้อป
        Disable_PetPanel();

    }
    void Enable_ShopTopazPanel() 
    {
           Panel_ShopTopaz.SetActive(true);
           Time.timeScale = 0; //หยุดจอเพื่อเปลี่ยนร่าง
    }
    void Disable_ShopTopazPanel()
    {
           Panel_ShopTopaz.SetActive(false);
           Time.timeScale = 1; //เริ่มเล่นต่อ
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
        void Enable_PetPanel() 
    {
           Panel_PetUI.SetActive(true);

    }
    void Disable_PetPanel()
    {
           Panel_PetUI.SetActive(false);

    }
}
