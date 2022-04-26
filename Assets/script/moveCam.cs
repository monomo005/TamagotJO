using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    public GameObject cam;
   public void transcamIN()
   {
       cam.transform.position = new Vector3(2.656f, 1.188f, -2.584f);
   }
   public void transcamOut()
   {
       cam.transform.position = new Vector3(2.45f, 1.02f, -2.56f);
   }
}
