using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpSide : MonoBehaviour
{
   public float TimA ;
    void Start()
    {
        
    }

    
    void Update()
    {
        
        if(ExpStat.instance.nextEXPtoLevelUp >=200)
            {
                transform.position = new Vector3 (1.698f, 0.931f, -1.64f);
                transform.localScale = new Vector3 (Random.Range(0.7f,0.7f),Random.Range(0.7f,0.7f),Random.Range(0.7f,0.7f));
                TimA -= Time.deltaTime;
              if(TimA <=0)
              {
                  transform.position = new Vector3(1.73f, 0.416f, -1.62f);
                  EggOpen.instance.catchEgg();
              }
            }
        if(ExpStat.instance.nextEXPtoLevelUp >=300)
            {
                transform.position = new Vector3 (1.698f, 0.931f, -1.64f);
                transform.localScale = new Vector3 (Random.Range(1.0f,1.0f),Random.Range(1.0f,1.0f),Random.Range(1.0f,1.0f));
                TimA -= Time.deltaTime;
                if(TimA <=0)
              {
                  transform.position = new Vector3(1.73f, 0.416f, -1.62f);
                  EggOpen.instance.catchEgg();
              }
            }
    }
   
}
