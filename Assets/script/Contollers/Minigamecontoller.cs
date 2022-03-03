using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Minigamecontoller : MonoBehaviour
{
    public static Minigamecontoller instance;
    public int Score = 0;

    private void Awake() 
    {
        instance = this;
    }
    void Update()
    {
        
    }
    public void Scoreplus(int ScoreAmount)
    {
        Score += ScoreAmount;
    }
    public void ClickplusScore()
    {
        Score += 1;
    }
}
