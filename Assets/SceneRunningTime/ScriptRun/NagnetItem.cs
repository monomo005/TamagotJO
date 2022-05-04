using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NagnetItem : MonoBehaviour
{
    public float MagnetTime;
    private bool MagnetSS;
    public static bool isMagnet;
    void Start()
    {
        MagnetTime =0;
        MagnetSS = false;
    }

    
    void Update()
    {
        if(MagnetSS)
       {
           MagnetTime += Time.deltaTime;
           if(MagnetTime >=3)
           {
               isMagnet = false;
                MagnetTime = 0;
                MagnetSS = false;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
         if(other.tag =="MagnetL")
        {
            MagnetSS = true;
            isMagnet = true;
            Destroy(other.gameObject);
        }
    }
}
