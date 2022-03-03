using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Shit : MonoBehaviour

{
    public static Shit instance;
    public GameObject Shit1;
    public GameObject Shit2;
    public GameObject Shit3;
    public float spawnTime = 5.0f;
    public int Shiter ;

    [SerializeField] int given3coin = 5;

    private void Awake() 
    {
        instance = this;
    }
    private void Start() 
    {
        InvokeRepeating ("Spawnshit1", spawnTime, spawnTime);
        InvokeRepeating ("Spawnshit2", spawnTime, spawnTime);
        InvokeRepeating ("Spawnshit3", spawnTime, spawnTime);
    }
    void Update()
    {
      OnMouseDown();
    }
    void Spawnshit1()
    {
     var newshit = GameObject.Instantiate(Shit1);
    }
    void Spawnshit2()
    {
     var newshit = GameObject.Instantiate(Shit2);
    }
    void Spawnshit3()
    {
     var newshit = GameObject.Instantiate(Shit3);
    }
     public void Update_Shit(int ShitAmount)
    {
        Shiter += ShitAmount;
        if(ShitAmount > 0)
        {
            
        }
        if(Shiter < 0)
        {
            PetManager.instance.Die();
        }
    }
    public void OnMouseDown() 
    {
        //Currency.instance.Update_Coin(given3coin);
        Destroy(gameObject);
    }
        
}
