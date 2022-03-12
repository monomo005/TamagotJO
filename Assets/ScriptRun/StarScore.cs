using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScore : MonoBehaviour
{
    public GameObject Star;
    public int score = 0;
    void Start()
    {
        score = 0;
    }

    
    void Update()
    {
        
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            Destroy(this.gameObject);
        }

    }
}
