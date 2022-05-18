using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFuniture : MonoBehaviour
{
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;

    public Currency currencyCoin;

    [SerializeField] int pay5coin = -5; 
    [SerializeField] int pay50coin = -50;
    [SerializeField] int pay100coin = -100;
    //[SerializeField] int pay500coin = -500;
    //[SerializeField] int pay1000coin = -1000;

    public Button Bot1,Bot2,Bot3,Bot4,Bot5;

    public bool isHaveMoney;

    public bool buyItem1;
    public bool buyItem2;
    public bool buyItem3;
    public bool buyItem4;
    public bool buyItem5;
    void Start()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
        Item5.SetActive(false);

        currencyCoin.GetComponent<Currency>();


        isHaveMoney = true;

        buyItem1 = false;
        buyItem2 = false;
        buyItem3 = false;
        buyItem4 = false;
        buyItem5 = false;
    }
    void Update()
    {
        
        if (currencyCoin.GetComponent<Currency>().Coin == 0)
        {
            isHaveMoney = false;
            Bot1.interactable = false;
            Bot2.interactable = false;
            Bot3.interactable = false;
            Bot4.interactable = false;
            Bot5.interactable = false;
        }else 
        {
            isHaveMoney = true;
            Bot1.interactable = true;
            Bot2.interactable = true;
            Bot3.interactable = true;
            Bot4.interactable = true;
            Bot5.interactable = true;
        }
        if (buyItem1 == true)
        {
            Bot1.interactable = false;
        }
        if (buyItem2 == true)
        {
            Bot2.interactable = false;
        }
        if (buyItem3 == true)
        {
            Bot3.interactable = false;
        }
        if (buyItem4 == true)
        {
            Bot4.interactable = false;
        }
        if (buyItem5 == true)
        {
            Bot5.interactable = false;
        }
        
    }
    public void onclick_buyItem1()
    {

         if (isHaveMoney == true)
    {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
        Item1.SetActive(true);
        buyItem1=true;
        
    }
    }
    public  void onclick_buyItem2()
    {

         if (isHaveMoney == true)
    {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
        Item2.SetActive(true);
        buyItem2=true;
    }
    }
     public void onclick_buyItem3()
    {

         if (isHaveMoney == true)
    {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay50coin);
        Item3.SetActive(true);
        buyItem3=true;
    }
    }
    public void onclick_buyItem4()
    {

         if (isHaveMoney == true)
    {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay50coin);
        Item4.SetActive(true);
        buyItem4=true;
    }
    }
   public  void onclick_buyItem5()
    {

         if (isHaveMoney == true)
    {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay100coin);
        Item5.SetActive(true);
        buyItem5=true;
    }
    }
}
