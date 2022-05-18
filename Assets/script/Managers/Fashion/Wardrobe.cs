using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wardrobe : MonoBehaviour
{
    public BuyFashion buyFashion;
    public Button Hat1,Hat2,Hat3,Hat4;
    public Button Shirt1,Shirt2,Shirt3,Shirt4,Shirt5;
    public Button Trouser1,Trouser2,Trouser3,Trouser4,Trouser5,Trouser6;
    public Button Shoe1,Shoe2,Shoe3;
    public Button Accessories1,Accessories2,Accessories3,Accessories4;
    void Start()
    {
        buyFashion.GetComponent<BuyFashion>();

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
    }


    void Update()
    {
        /*if (buyFashion.GetComponent<BuyFashion>().hat1 == true)
        {
             Hat1.interactable = true;
        }*/
        if (buyFashion.GetComponent<BuyFashion>().hat2 == true)
        {
             Hat2.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().hat3 == true)
        {
             Hat3.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().hat4 == true)
        {
             Hat4.interactable = true;
        }
        /*if (buyFashion.GetComponent<BuyFashion>().shirt1 == true)
        {
             Shirt1.interactable = true;
        }*/
        if (buyFashion.GetComponent<BuyFashion>().shirt2 == true)
        {
             Shirt2.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().shirt3 == true)
        {
             Shirt3.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().shirt4 == true)
        {
             Shirt4.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().shirt5 == true)
        {
             Shirt5.interactable = true;
        }
        /*if (buyFashion.GetComponent<BuyFashion>().trouser1 == true)
        {
             Trouser1.interactable = true;
        }*/
        if (buyFashion.GetComponent<BuyFashion>().trouser2 == true)
        {
             Trouser2.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().trouser3 == true)
        {
             Trouser3.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().trouser4 == true)
        {
             Trouser4.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().trouser5 == true)
        {
             Trouser5.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().trouser6 == true)
        {
             Trouser6.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().shoe1 == true)
        {
             Shoe1.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().shoe2 == true)
        {
             Shoe2.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().shoe3 == true)
        {
             Shoe3.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().accessories1 == true)
        {
             Accessories1.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().accessories2 == true)
        {
             Accessories2.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().accessories3 == true)
        {
             Accessories3.interactable = true;
        }
        if (buyFashion.GetComponent<BuyFashion>().accessories4 == true)
        {
             Accessories4.interactable = true;
        }
    }
    
}
