using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Topaz : MonoBehaviour
{
     public static Topaz instance;
    public int Topas = 0;

    public int Energy = 25;

    public int limitTopazExchange = 20;

    DateTime lastExecution = DateTime.UtcNow;
    DateTime current;
    DateTime tomorrow;

    private void Awake() 
    {
        instance = this;        
    }

    
    void Update()
    {
        current = DateTime.UtcNow;
        tomorrow = current.AddDays(1).Date;
        //Debug.Log((tomorrow - current).TotalHours);
        //Debug.Log(current);
        if (lastExecution.Day < current.Day)
        {
            lastExecution = current;            
        }

        if (lastExecution.Day > current.Day)
        {
            lastExecution = tomorrow;
            limitTopazExchange = 20;
        }
    }
    public void Update_Topas(int TopasAmount)
    {
        Topas += TopasAmount;
    }

    public void TopasEnergyExchange()
    {
        if (limitTopazExchange > 0)
        {
            if (Topas >= 10)
            {
                Topas -= 10;
                Energy += 25;
                limitTopazExchange -= 1;
            }
            else if (Topas < 10)
            {
                Debug.Log("You don't have enough Topaz");
            }
        }

        else if (limitTopazExchange == 0)
        {
            Debug.Log("You're limit Topaz Exchange today");
        }
    }

    public void TopasAdd()
    {
        Topas += 10;
    }
}
