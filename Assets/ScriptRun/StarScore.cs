using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StarScore : MonoBehaviour
{
    void Start()
    {

    }

    
    void Update()
    {
        transform.Rotate(0,1,0);
    }
     void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Charecter.numberCoin +=1;

            Destroy(gameObject);
        }

    }
}
