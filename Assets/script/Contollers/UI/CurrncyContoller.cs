using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrncyContoller : MonoBehaviour
{
    [SerializeField] Text CurrencyValue;
    [SerializeField] Text TopazValue;
    float targetCurrencyValue = 1.0f;
    float targetTopazValue = 1.0f;
  


    void Update()
    {
        Update_CurrencyValue();
        Update_TopazValue();
    }
    void Update_CurrencyValue()
    {
    CurrencyValue.text = GetComponent<Currency>().Coin + " " ;
    targetCurrencyValue = GetComponent<Currency>().Coin *1.0f;
    }
    void Update_TopazValue()
    {
    TopazValue.text = Topaz.instance.Topas + " " ;
    targetTopazValue =  Topaz.instance.Topas *1.0f;
    }
}
