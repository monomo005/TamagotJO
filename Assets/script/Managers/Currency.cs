using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{
    public static Currency instance;
    
    public int Coin;
    
    private void Awake() 
    {
        instance = this;
    }
    void start()
    {
        Coin = 100;
    }
    void Update()
    {
        
    }
    public void Update_Coin(int CoinAmount)
    {
        Coin += CoinAmount;
        if(Coin <= 0)
        {
            Coin = 0;
        }

    }
   
    

}
