using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner3 : MonoBehaviour
{
    public static Spawner3 instance;
    public GameObject objToSpawn;
    public float  timeLeft, originalTime;

private void Awake() 
    {
        instance = this;
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        timeLeft -=Time.deltaTime;
        if(timeLeft<=0)
        {
            SpawnIt();
            timeLeft = originalTime;
        }
    }
    public void SpawnIt()
    {
        Instantiate(objToSpawn, transform.position, Quaternion.identity);
    }
}
