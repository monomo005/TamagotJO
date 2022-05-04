using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggOpen : MonoBehaviour
{

    public static EggOpen instance;
    public GameObject Egg;
    public GameObject Host;

    
    private void Awake() 
    {
        instance = this;
    }
    public void start()
    {
        Egg.SetActive(false);
    }
    public void OpEgg1()
    {
        Egg.SetActive(true);
        Egg.GetComponent<Animator>().Play("Open");
        


    }
    
    public void OpEgg2()
    {
        Egg.SetActive(true);
        Egg.GetComponent<Animator>().Play("Open");
        
        


    }
    public void catchEgg()
    {
        Egg.SetActive(false);
    }
}
