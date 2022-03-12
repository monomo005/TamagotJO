using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartSreen : MonoBehaviour
{
    [SerializeField] GameObject Panel_Start;
    void Start()
    {
        Enable_StartPanel();
    }

    
    void Update()
    {
        
    }
    public void Clock_ToStart()
    {
         Disable_StartPanel();
    }
    public void Click_ToChangeScene()
    {
        SceneManager.LoadScene("SceneSubway", LoadSceneMode.Single);
    }
    public void Click_Tobackgame()
    {
        SceneManager.LoadScene("GameScene", LoadSceneMode.Single);
    }
    void Enable_StartPanel() 
    {
           Panel_Start.SetActive(true);
           Time.timeScale = 0; //หยุดจอเพื่อเปลี่ยนร่าง
    }
    void Disable_StartPanel()
    {
           Panel_Start.SetActive(false);
           Time.timeScale = 1; //เริ่มเล่นต่อ
    }
}
