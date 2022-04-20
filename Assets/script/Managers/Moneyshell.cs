using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneyshell : MonoBehaviour
{
    [SerializeField] int given3Coin = 3;
    void OnMouseDown()
    {
        Currency.instance.Update_Coin(given3Coin);
        Destroy(gameObject);
    }
}
