using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] int given10Coin = 20;
    void OnMouseDown()
    {
        Currency.instance.Update_Coin(given10Coin);
        Destroy(gameObject);
    }
}
