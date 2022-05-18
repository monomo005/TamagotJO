using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuyFashion : MonoBehaviour
{
    [SerializeField] int pay5coin = -5; 
    [SerializeField] int pay50coin = -50;
    [SerializeField] int pay100coin = -100;
    //[SerializeField] int pay500coin = -500;
    //[SerializeField] int pay1000coin = -1000;

    public Currency currencyCoin;
    public bool isHaveMoney;

    public Button Hat1,Hat2,Hat3,Hat4;
    public Button Shirt1,Shirt2,Shirt3,Shirt4,Shirt5;
    public Button Trouser1,Trouser2,Trouser3,Trouser4,Trouser5,Trouser6;
    public Button Shoe1,Shoe2,Shoe3;
    public Button Accessories1,Accessories2,Accessories3,Accessories4;

    public bool hat1,hat2,hat3,hat4;
    public bool shirt1,shirt2,shirt3,shirt4,shirt5;
    public bool trouser1,trouser2,trouser3,trouser4,trouser5,trouser6;
    public bool shoe1,shoe2,shoe3;
    public bool accessories1,accessories2,accessories3,accessories4;


    void Start()
    {
        currencyCoin.GetComponent<Currency>();
        isHaveMoney = true;

        /*hat1 = false;*/
        hat2 = false;
        hat3 = false;
        hat4 = false;
        /*shirt1 = false;*/
        shirt2 = false;
        shirt3 = false;
        shirt4 = false;
        shirt5 = false;
        /*trouser1 = false;*/
        trouser2 = false;
        trouser3 = false;
        trouser4 = false;
        trouser5 = false;
        trouser6 = false;
        shoe1 = false;
        shoe2 = false;
        shoe3 = false;
        accessories1 = false;
        accessories2 = false;
        accessories3 = false;
        accessories4 = false;
    }


    void Update()
    {
        if (currencyCoin.GetComponent<Currency>().Coin == 0)
        {
            isHaveMoney = false;
            Hat1.interactable = true;
            Hat2.interactable = false;
            Hat3.interactable = false;
            Hat4.interactable = false;
            Shirt1.interactable = true;
            Shirt2.interactable = false;
            Shirt3.interactable = false;
            Shirt4.interactable = false;
            Shirt5.interactable = false;
            Trouser1.interactable = true;
            Trouser2.interactable = false;
            Trouser3.interactable = false;
            Trouser4.interactable = false;
            Trouser5.interactable = false;
            Trouser6.interactable = false;
            Shoe1.interactable = false;
            Shoe2.interactable = false;
            Shoe3.interactable = false;
            Accessories1.interactable = false;
            Accessories2.interactable = false;
            Accessories3.interactable = false;
            Accessories4.interactable = false;
        
        }else 
        {
            isHaveMoney = true;
            Hat1.interactable = true;
            Hat2.interactable = true;
            Hat3.interactable = true;
            Hat4.interactable = true;

            Shirt1.interactable = true;
            Shirt2.interactable = true;
            Shirt3.interactable = true;
            Shirt4.interactable = true;
            Shirt5.interactable = true;

            Trouser1.interactable = true;
            Trouser2.interactable = true;
            Trouser3.interactable = true;
            Trouser4.interactable = true;
            Trouser5.interactable = true;
            Trouser6.interactable = true;

            Shoe1.interactable = true;
            Shoe2.interactable = true;
            Shoe3.interactable = true;

            Accessories1.interactable = true;
            Accessories2.interactable = true;
            Accessories3.interactable = true;
            Accessories4.interactable = true;
        }
        if (hat1 == true)
        {
            Hat1.interactable = false;
        }
        if (hat2 == true)
        {
            Hat1.interactable = false;
        }
        if (hat3 == true)
        {
            Hat1.interactable = false;
        }
        if (hat4 == true)
        {
            Hat1.interactable = false;
        }


        if (shirt1 == true)
        {
            Shirt1.interactable = false;
        }
        if (shirt2 == true)
        {
            Shirt2.interactable = false;
        }
        if (shirt3 == true)
        {
            Shirt3.interactable = false;
        }
        if (shirt4 == true)
        {
            Shirt4.interactable = false;
        }
        if (shirt5 == true)
        {
            Shirt5.interactable = false;
        }

        if (trouser1 == true)
        {
            Trouser1.interactable = false;
        }
        if (trouser2 == true)
        {
            Trouser2.interactable = false;
        }
        if (trouser3 == true)
        {
            Trouser3.interactable = false;
        }
        if (trouser4 == true)
        {
            Trouser4.interactable = false;
        }
        if (trouser5 == true)
        {
            Trouser5.interactable = false;
        }
        if (trouser6 == true)
        {
            Trouser6.interactable = false;
        }

        if (shoe1 == true)
        {
            Shoe1.interactable = false;
        }
        if (shoe2 == true)
        {
            Shoe2.interactable = false;
        }
        if (shoe3 == true)
        {
            Shoe3.interactable = false;
        }

        if (accessories1 == true)
        {
            Accessories1.interactable = false;
        }
        if (accessories2 == true)
        {
            Accessories2.interactable = false;
        }
        if (accessories3 == true)
        {
            Accessories3.interactable = false;
        }
        if (accessories4 == true)
        {
            Accessories4.interactable = false;
        }
    }

    public void onclick_BuyHat1()
    {

         if (isHaveMoney == true)
        {
        //Hat1.SetActive(true);
        hat1=true;
        }
    }
    public void onclick_BuyHat2()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
        //Hat2.SetActive(true);
        hat2=true;
        }
    }
    public void onclick_BuyHat3()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
        //Hat3.SetActive(true);
        hat3=true;
        }
    }
    public void onclick_BuyHat4()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay100coin);
        //Hat4.SetActive(true);
        hat4=true;
        }
    }
    //---------------------------------------------------------------------------//
    public void onclick_BuyShirt1()
    {

         if (isHaveMoney == true)
        {
        //Shirt1.SetActive(true);
        shirt1=true;
        }
    }
    public void onclick_BuyShirt2()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
        //Shirt2.SetActive(true);
        shirt2=true;
        }
    }
    public void onclick_BuyShirt3()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay50coin);
        //Shirt3.SetActive(true);
        shirt3=true;
        }
    }
    public void onclick_BuyShirt4()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay100coin);
        //Shirt4.SetActive(true);
        shirt4=true;
        }
    }
    public void onclick_BuyShirt5()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
        //Shirt5.SetActive(true);
        shirt5=true;
        }
    }
    //---------------------------------------------------------------------------//
    public void onclick_Buytrouser1()
    {

         if (isHaveMoney == true)
        {
        //Trouser1.SetActive(true);
        trouser1=true;
        }
    }
    public void onclick_Buytrouser2()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
        //Trouser2.SetActive(true);
        trouser2=true;
        }
    }
    public void onclick_Buytrouser3()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay50coin);
        //Trouser3.SetActive(true);
        trouser3=true;
        }
    }
    public void onclick_Buytrouser4()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay50coin);
        //Trouser4.SetActive(true);
        trouser4=true;
        }
    }
    public void onclick_Buytrouser5()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay100coin);
        //Trouser5.SetActive(true);
        trouser5=true;
        }
    }
    public void onclick_Buytrouser6()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay100coin);
        //Trouser6.SetActive(true);
        trouser6=true;
        }
    }
    //---------------------------------------------------------------------------//
public void onclick_Buyshoe1()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
        //shoe1.SetActive(true);
        shoe1=true;
        }
    }
public void onclick_Buyshoe2()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay50coin);
        //shoe2.SetActive(true);
        shoe2=true;
        }
    }
public void onclick_Buyshoe3()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay100coin);
        //shoe3.SetActive(true);
        shoe3=true;
        }
    }
     //---------------------------------------------------------------------------//
     public void onclick_Buyaccessories1()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay50coin);
        //Accessories1.SetActive(true);
        accessories1=true;
        }
    }
    public void onclick_Buyaccessories2()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay50coin);
        //Accessories2.SetActive(true);
        accessories2=true;
        }
    }
    public void onclick_Buyaccessories3()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay100coin);
        //Accessories3.SetActive(true);
        accessories3=true;
        }
    }
    public void onclick_Buyaccessories4()
    {

         if (isHaveMoney == true)
        {
        currencyCoin.GetComponent<Currency>().Update_Coin(pay100coin);
        //Accessories4.SetActive(true);
        accessories4=true;
        }
    }
}

