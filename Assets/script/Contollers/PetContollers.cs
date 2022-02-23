using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetContollers : MonoBehaviour
{
   public Animator petAnimator;
   private Vector3 _destination;
   public float speed;

       private void Awake() 
       {
           
       }
       private void Update()
       {
           if(Vector3.Distance(transform.position,_destination) > 0.5f)
           {
               transform.position = Vector3.MoveTowards(transform.position,_destination, speed*Time.deltaTime);
           }
       }
    public void Move(Vector3 destination)
    {
        this._destination = destination;
    }
       public void Run()
       {
           petAnimator.SetTrigger("Run");
       }
       public void Eat()
       {
           petAnimator.SetTrigger("Eat");
       }
       public void walk()
       {
           petAnimator.SetTrigger("walk");
       }
       public void Jump()
       {
           petAnimator.SetTrigger("Jump");
       }
    
}
