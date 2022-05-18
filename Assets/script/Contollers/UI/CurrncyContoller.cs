using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CurrncyContoller : MonoBehaviour
{
    [SerializeField] Text CurrencyValue;
    [SerializeField] Text TopazValue;
    [SerializeField] Text CurrencyValue2;
    [SerializeField] Text TopazValue2;
        [SerializeField] Text CurrencyValue3;
    [SerializeField] Text TopazValue3;
    float targetCurrencyValue = 1.0f;
    float targetTopazValue = 1.0f;
    float targetCurrencyValue2 = 1.0f;
    float targetTopazValue2 = 1.0f;
        float targetCurrencyValue3 = 1.0f;
    float targetTopazValue3 = 1.0f;
  
  


    void Update()
    {
        Update_CurrencyValue();
        Update_TopazValue();
    }
    void Update_CurrencyValue()
    {
    CurrencyValue.text = GetComponent<Currency>().Coin + " " ;
    targetCurrencyValue = GetComponent<Currency>().Coin *1.0f;

    CurrencyValue2.text = GetComponent<Currency>().Coin + " " ;
    targetCurrencyValue2 = GetComponent<Currency>().Coin *1.0f;

        CurrencyValue3.text = GetComponent<Currency>().Coin + " " ;
    targetCurrencyValue3 = GetComponent<Currency>().Coin *1.0f;
    }
    void Update_TopazValue()
    {
    TopazValue.text = Topaz.instance.Topas + " " ;
    targetTopazValue =  Topaz.instance.Topas *1.0f;

        TopazValue2.text = Topaz.instance.Topas + " " ;
    targetTopazValue2 =  Topaz.instance.Topas *1.0f;

            TopazValue3.text = Topaz.instance.Topas + " " ;
    targetTopazValue3 =  Topaz.instance.Topas *1.0f;
    }
}
