using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friends : MonoBehaviour
{
    public static friends instance;
    [SerializeField] GameObject Panel_friend;
    private void Awake() 
    {
        instance = this;
    }
    void Start()
    {
        
    }
    public void Click_Tofriend()
    {
        Enable_friendPanel();
    }
    public void Click_TobackF()
    {
        Disable_friendPanel();
    }
    void Enable_friendPanel() 
    {
           Panel_friend.SetActive(true);
           Time.timeScale = 0; //หยุดจอเพื่อเปลี่ยนร่าง
    }
    void Disable_friendPanel()
    {
           Panel_friend.SetActive(false);
           Time.timeScale = 1; //เริ่มเล่นต่อ
    }
}
