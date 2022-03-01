using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shit : MonoBehaviour

{
    public static Shit instance;     
    public int Shiter = 0;
    private void Awake() 
    {
        instance = this;
    }
    void Update()
    {
        
    }
     public void Update_Shit(int ShitAmount)
    {
        Shiter += ShitAmount;
        if(ShitAmount > 0)
        {

        }
        if(Shiter < 0)
        {
            PetManager.instance.Die();
        }
    }
        
}
