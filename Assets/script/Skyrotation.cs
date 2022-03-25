using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skyrotation : MonoBehaviour
{
    public float skyboxspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat ("_Rotation", Time.time * skyboxspeed);
    }
}
