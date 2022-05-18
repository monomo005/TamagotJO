using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SetupStorge : MonoBehaviour
{
    [SerializeField] GameObject sandbox;
    [SerializeField] GameObject sandboxOn;
    [SerializeField] GameObject sandboxOff;
    [SerializeField] GameObject umballra;
    [SerializeField] GameObject umballraOn;
    [SerializeField] GameObject umballraOff;
    [SerializeField] GameObject sandcastle;
    [SerializeField] GameObject sandcastleOn;
    [SerializeField] GameObject sandcastleOff;
    [SerializeField] GameObject lifebuoy;
    [SerializeField] GameObject lifebuoyOn;
    [SerializeField] GameObject lifebuoyOff;
    [SerializeField] GameObject chair;
    [SerializeField] GameObject chairOn;
    [SerializeField] GameObject chairOff;

    public Button SandboxOn,UmballraOn,SandcastleOn,LifebuoyOn,ChairOn;
    public Button SandboxOff,UmballraOff,SandcastleOff,LifebuoyOff,ChairOff;

    public BuyFuniture buyFuniture;
    void Start()
    {
        buyFuniture.GetComponent<BuyFuniture>();

            SandboxOn.interactable = false;
            SandboxOff.interactable = false;
             UmballraOn.interactable = false;
            UmballraOff.interactable = false;
            SandcastleOn.interactable = false;
            SandcastleOff.interactable = false;
            LifebuoyOn.interactable = false;
            LifebuoyOff.interactable = false;
            ChairOn.interactable = false;
            ChairOff.interactable = false;

    }
    void Update()
    {
         if (buyFuniture.GetComponent<BuyFuniture>().buyItem1 == true)
        {
            SandboxOn.interactable = true;
            SandboxOff.interactable = true;
        }
        if (buyFuniture.GetComponent<BuyFuniture>().buyItem2 == true)
        {
            UmballraOn.interactable = true;
            UmballraOff.interactable = true;
        }
        if (buyFuniture.GetComponent<BuyFuniture>().buyItem3 == true)
        {
          
            SandcastleOn.interactable = true;
            SandcastleOff.interactable = true;
        }
        if (buyFuniture.GetComponent<BuyFuniture>().buyItem4 == true)
         {         
            LifebuoyOn.interactable = true;
            LifebuoyOff.interactable = true;
        }
        if (buyFuniture.GetComponent<BuyFuniture>().buyItem5 == true)
        {
            ChairOn.interactable = true;
            ChairOff.interactable = true;
        }
    }
    public void click_open_sandbox()
    {
        Enable_sandbox();
    }
    public void click_close_sandbox()
    {
        Disable_sandbox();
    }
    void Enable_sandbox()
    {
        sandbox.SetActive(true);
        sandboxOn.SetActive(true);
        sandboxOff.SetActive(false);
    }
    void Disable_sandbox()
    {
        sandbox.SetActive(false);
        sandboxOn.SetActive(false);
        sandboxOff.SetActive(true);
    }
    public void click_open_umballra()
    {
        Enable_umballra();
    }
    public void click_close_umballra()
    {
        Disable_umballra();
    }
    void Enable_umballra()
    {
        umballra.SetActive(true);
        umballraOn.SetActive(true);
        umballraOff.SetActive(false);
    }
    void Disable_umballra()
    {
        umballra.SetActive(false);
        umballraOn.SetActive(false);
        umballraOff.SetActive(true);
    }
    public void click_open_sandcastle()
    {
        Enable_sandcastle();
    }
    public void click_close_sandcastle()
    {
        Disable_sandcastle();
    }
    void Enable_sandcastle()
    {
        sandcastle.SetActive(true);
        sandcastleOn.SetActive(true);
        sandcastleOff.SetActive(false);
    }
    void Disable_sandcastle()
    {
        sandcastle.SetActive(false);
        sandcastleOn.SetActive(false);
        sandcastleOff.SetActive(true);
    }
    public void click_open_lifebuoy()
    {
        Enable_lifebuoy();
    }
    public void click_close_lifebuoy()
    {
        Disable_lifebuoy();
    }
    void Enable_lifebuoy()
    {
        lifebuoy.SetActive(true);
        lifebuoyOn.SetActive(true);
        lifebuoyOff.SetActive(false);
    }
    void Disable_lifebuoy()
    {
        lifebuoy.SetActive(false);
        lifebuoyOn.SetActive(false);
        lifebuoyOff.SetActive(true);
    }
     public void click_open_chair()
    {
        Enable_chair();
    }
    public void click_close_chair()
    {
        Disable_chair();
    }
    void Enable_chair()
    {
        chair.SetActive(true);
        chairOn.SetActive(true);
        chairOff.SetActive(false);
    }
    void Disable_chair()
    {
        chair.SetActive(false);
        chairOn.SetActive(false);
        chairOff.SetActive(true);
    }

}
