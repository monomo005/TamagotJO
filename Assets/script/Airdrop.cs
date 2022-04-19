using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airdrop : MonoBehaviour
{
    public float objectSpeed = -5f;

    void Update()
    {
     transform.Translate(Vector3.down * Time.deltaTime, Space.World);
    }

void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Eat")
        {
            Debug.Log("Hit");
        Destroy(this.gameObject);
        }
    }
}
