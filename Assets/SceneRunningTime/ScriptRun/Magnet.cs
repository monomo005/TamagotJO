using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnet : MonoBehaviour
{
    public bool flytoplayer;
    private float speed = 800;
    Rigidbody rb;
    GameObject player;
    Vector3 playerDiraction;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if(flytoplayer && NagnetItem.isMagnet)
        {
            playerDiraction = -(transform.position-player.transform.position).normalized;
            rb.velocity=new Vector3(playerDiraction.x,playerDiraction.y,playerDiraction.z)*speed*Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
    if (other.gameObject.name.Equals("MagnetAreaL"))
        {
            flytoplayer = true;
            
        }

        if(other.tag == "player")
        { 
            Destroy(gameObject);
        }   
 }
}
