using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharkswin : MonoBehaviour
{
    public GameObject sherk;
      public float speed;
   
    void Update()
    {
        float x = Mathf.PingPong(Time.time * speed, 1) * -45;
          sherk.transform.position = new Vector3(x, -0.56f, 29.65f);
    }
}
