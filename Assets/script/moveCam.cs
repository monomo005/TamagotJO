using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    public GameObject cam;
   public void transcamIN()
   {
       cam.transform.position = new Vector3(2.656f, 1.188f, -2.584f);
       cam.transform.Rotate(9.793f, -20.766f, 0f);
   }
   public void transcamOut()
   {
       cam.transform.position = new Vector3(2.45f, 1.02f, -2.56f);
       cam.transform.Rotate(9.793f, -20.766f, 0f);
   }
   public void transcamOutfast()
   {
       cam.transform.position = new Vector3(6.08f, 2.18f, -7.75f);
       cam.transform.Rotate(9.517f, -34.527f, 1.768f);
   }
}
