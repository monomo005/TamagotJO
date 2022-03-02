using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shopfood : MonoBehaviour
{
    public static Shopfood instance;
    [SerializeField] GameObject Panel_shop;
    [SerializeField] GameObject Panel_shopfood;
     private void Awake() 
    {
        instance = this;
    }
     void Start() 
    {
    
    }
   
    public void Click_ToShopfood()
    {
        Enable_ShopfoodPanel(); //เปิดช้อปอาหาร
        Disable_ShopPanel(); //ปิดช้อป
    }
    public void Click_Toback()
    {
        Disable_ShopfoodPanel(); //ปิดช้อปอาหาร
        Enable_ShopPanel(); //เปิดช้อป
    }
    void Enable_ShopfoodPanel() 
    {
           Panel_shopfood.SetActive(true);
           Time.timeScale = 0; //หยุดจอเพื่อเปลี่ยนร่าง
    }
    void Disable_ShopfoodPanel()
    {
           Panel_shopfood.SetActive(false);
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
}
