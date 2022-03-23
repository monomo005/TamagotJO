using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(-1,-1,0);
    }
    //void OnTriggerEnter(Collider other)
    //{
        //if(other.tag =="Obstract")
        //{
        //    Destroy(gameObject);
        //}
    //}
}
