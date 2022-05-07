using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printer : MonoBehaviour
{
     public static Printer instance;
    [SerializeField] GameObject Panel_Printer;
    [SerializeField] GameObject Panel_Option;

   private void Awake() 
    {
        instance = this;
    }
    public void Click_ToPrinterup()
    {
        Enable_PrinterPanel();
    }
    public void Click_ToPrinterF()
    {
        Disable_PrinterPanel();
    }
    void Enable_PrinterPanel() 
    {
           Panel_Printer.SetActive(true);
           Panel_Option.SetActive(false);
    }
    void Disable_PrinterPanel()
    {
           Panel_Printer.SetActive(false);
           Panel_Option.SetActive(true);
    }
}
