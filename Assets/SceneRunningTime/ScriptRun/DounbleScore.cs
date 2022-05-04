using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DounbleScore : MonoBehaviour
{
    public float doubleSpeedTime;
    private bool doubleSS;
    void Start()
    {
        doubleSpeedTime =0;
        doubleSS = false;
    }

    
    void Update()
    {
       if(doubleSS)
       {
           doubleSpeedTime += Time.deltaTime;
           if(doubleSpeedTime >=3)
           {
                Charecter.numberCoin += 1 ;
                doubleSpeedTime = 0;
                doubleSS = false;
            }
        }
       }
       void OnTriggerEnter(Collider other)
    {
        if(other.tag =="DoublePotion")
        {
            doubleSS = true;
            Charecter.numberCoin += 2;
            Destroy(other.gameObject);
        }
    }
}
