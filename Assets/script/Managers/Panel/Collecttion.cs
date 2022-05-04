using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecttion : MonoBehaviour
{
        public static Collecttion instance;
    [SerializeField] GameObject Head_Fashion;
    [SerializeField] GameObject Head_Funiture;
    [SerializeField] GameObject meat_Fashion;
    [SerializeField] GameObject meat_Funiture;
    private void Awake() 
    {
        instance = this;
    }
   public void Click_ToHeadFashion()
    {
        Enable_HeadFashion();
    }
    public void Click_ToHeadFuniture()
    {
        Enable_HeadFuniture();
    }
    void Enable_HeadFashion() 
    {

           meat_Fashion.SetActive(true);
           meat_Funiture.SetActive(false);
    }
    void Enable_HeadFuniture()
    {
           meat_Fashion.SetActive(false);
           meat_Funiture.SetActive(true);
    }
}
