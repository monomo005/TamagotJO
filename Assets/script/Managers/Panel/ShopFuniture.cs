using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopFuniture : MonoBehaviour
{
    public static ShopFuniture instance;
    [SerializeField] GameObject Panel_shop;
    [SerializeField] GameObject Panel_shopfuniture;
    [SerializeField] GameObject Panel_PetUI;
     private void Awake() 
    {
        instance = this;
    }
     void Start() 
    {
    
    }
   
    public void Click_ToShopfuniture()
    {
        Enable_ShopfuniturePanel(); //เปิดร้านเฟอร์นิเจอร์
        Disable_ShopPanel(); //ปิดช้อป
        Disable_PetPanel();
    }
    public void Click_Toback()
    {
        Disable_ShopfuniturePanel(); //ปิดร้านเฟอร์นิเจอร์
        Enable_ShopPanel(); //เปิดช้อป
        Disable_PetPanel();

    }
    void Enable_ShopfuniturePanel() 
    {
           Panel_shopfuniture.SetActive(true);
           Time.timeScale = 0; //หยุดจอเพื่อเปลี่ยนร่าง
    }
    void Disable_ShopfuniturePanel()
    {
           Panel_shopfuniture.SetActive(false);
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
