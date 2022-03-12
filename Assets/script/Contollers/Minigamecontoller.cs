using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Minigamecontoller : MonoBehaviour
{
    public static Minigamecontoller instance;
    public float Score ;
    public Text T1;
    public Text S1;
    public Text T2;
    public Text S2;
    public float number ;
    [SerializeField] GameObject Panel_Stop;

    private void Awake() 
    {
        instance = this;
    }
    void Update()
    {
        
    }

    public void TimeCountDown()
    {
        number -= Time.deltaTime;
        T1.text = System.Math.Round(number).ToString();
        if(number <= 0)
        {
            T1.text = "Timeout";
            Enable_StopPanel();

        }
        T2.text = System.Math.Round(number).ToString();
        if(number <= 0)
        {
            T2.text = "Timeout";
            Enable_StopPanel();

        }
    }
    void Enable_StopPanel() 
    {
           Panel_Stop.SetActive(true);
           
    }
    
    public void ClickplusScore()
    {
        Score += 1.0f;
        S1.text = System.Math.Round(Score).ToString();
        S2.text = System.Math.Round(Score).ToString();
        
    }
    public void resetScore()
 {
     PlayerPrefs.SetInt ("Score", 0);
 }
}
