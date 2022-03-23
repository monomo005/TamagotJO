using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Obstract : MonoBehaviour
{
    [SerializeField] GameObject Panel_End;
    [SerializeField] GameObject Panel_Score;
    void Start()
    {
        Disable_EndPanel();
    }
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag =="Obstract")
        {
            Enable_EndPanel();
        }
    }
   public void Enable_EndPanel() 
    {
           Panel_Score.SetActive(false);
           Panel_End.SetActive(true);   
           Time.timeScale = 0; //หยุดจอเพื่อเปลี่ยนร่าง
    }
   public void Disable_EndPanel()
    {
           Panel_Score.SetActive(true);
           Panel_End.SetActive(false);
           Time.timeScale = 1; //เริ่มเล่นต่อ
    }
    public void On_ClickBack()
    {
    SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
}
