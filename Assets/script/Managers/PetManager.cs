using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PetManager : MonoBehaviour
{
  public PetContollers pet;
  public float petMoveTimer, originalpetMoveTimer;
  public Transform [] waypoints;

  public NeedsController needsController;
  public static PetManager instance;
private void Awake() 
    {
      originalpetMoveTimer = petMoveTimer;
      if(instance == null)
      {
          instance = this;
      }
      else Debug.LogWarning("More than one PetManager in the Scene"); 
    }
    private void Update() 
    {
    if(petMoveTimer > 0)  
      {
      petMoveTimer -= Time.deltaTime; 
      }
    else
      {
      movePetToRandomWaypoint();
      petMoveTimer = originalpetMoveTimer;
      
      }
    }
    private void movePetToRandomWaypoint()
    {
        int randomWaypoint = Random.Range(0, waypoints.Length);
        pet.Move(waypoints[randomWaypoint].position);
    }
    public void Die() 
    {
        
    }
}
