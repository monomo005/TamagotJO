using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
     public static Inventory instance;
    [SerializeField] GameObject Panel_Inventory;
     private void Awake() 
    {
        instance = this;
    }
     void Start() 
    {
    
    }
    public void Click_ToInventory()
    {
        Enable_InventoryPanel();
    }
    public void Click_Toback()
    {
        Disable_InventoryPanel();
    }
    void Enable_InventoryPanel() 
    {
           Panel_Inventory.SetActive(true);
           Time.timeScale = 0; //หยุดจอเพื่อเปลี่ยนร่าง
    }
    void Disable_InventoryPanel()
    {
           Panel_Inventory.SetActive(false);
           Time.timeScale = 1; //เริ่มเล่นต่อ
    }
}
