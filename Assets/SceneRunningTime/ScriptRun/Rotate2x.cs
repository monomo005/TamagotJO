using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate2x : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,-1,0);
    }
     //void OnTriggerEnter(Collider other)
    //{
        //if(other.tag =="Obstract")
        //{
        //     Destroy(other.gameObject);
        //}
    //}
}
