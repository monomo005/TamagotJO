using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Topaz : MonoBehaviour
{
    public static Topaz instance;
    public int Topas = 0;
   private void Awake() 
    {
        instance = this;
    }

    
    void Update()
    {
        
    }
    public void Update_Topas(int TopasAmount)
    {
        Topas += TopasAmount;

    }
}
