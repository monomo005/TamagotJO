using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpSide : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if(ExpStat.instance.nextEXPtoLevelUp >=200)
            {
                transform.localScale = new Vector3 (Random.Range(0.7f,0.7f),Random.Range(0.7f,0.7f),Random.Range(0.7f,0.7f));
            }
        if(ExpStat.instance.nextEXPtoLevelUp >=300)
            {
                transform.localScale = new Vector3 (Random.Range(1.0f,1.0f),Random.Range(1.0f,1.0f),Random.Range(1.0f,1.0f));
            }
    }
}
