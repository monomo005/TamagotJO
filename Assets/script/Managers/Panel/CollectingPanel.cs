using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectingPanel : MonoBehaviour
{
    public static CollectingPanel instance;
    [SerializeField] GameObject Panel_Collection;
    [SerializeField] GameObject Panel_Option;
    private void Awake() 
    {
        instance = this;
    }
   public void Click_ToCollect()
    {
        Enable_CollectPanel();
    }
    public void Click_ToCollectF()
    {
        Disable_CollectPanel();
    }
    void Enable_CollectPanel() 
    {
           Panel_Collection.SetActive(true);
           Panel_Option.SetActive(false);
    }
    void Disable_CollectPanel()
    {
           Panel_Collection.SetActive(false);
           Panel_Option.SetActive(true);
    }
}
