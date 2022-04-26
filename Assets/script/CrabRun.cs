using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrabRun : MonoBehaviour
{
    public GameObject sherk;
      public float speed;
   
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, 1) * -3;
          sherk.transform.position = new Vector3(x, 0.488f, 0.116f);
    }
}
