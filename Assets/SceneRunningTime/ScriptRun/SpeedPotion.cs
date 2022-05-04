using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPotion : MonoBehaviour
{
    public  float PotionTime ;
    private bool boosting;
    Obstract obstract;
    void Start()
    {
        PotionTime =0;
        boosting = false;
    }

    // Update is called once per frame
    void Update()
    {
      if(boosting)
        {
            PotionTime += Time.deltaTime;
            if(PotionTime >=2)
            {
                Charecter.FwdSpeed += -5;
                PotionTime = 0;
                boosting = false;
            }
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.tag =="SpeedsPotion")
        {
            boosting = true;
            Charecter.FwdSpeed += 5;
            Destroy(other.gameObject);
        }
    }
    
}
