using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    [SerializeField] int given10Coin = 20;

    public CoconutSpawning coco;

    private void Start()
    {
        if (coco == null) coco = GameObject.FindGameObjectWithTag("Coco").GetComponent<CoconutSpawning>();
        coco.GetComponent<CoconutSpawning>();
    }
    void OnMouseDown()
    {
        Currency.instance.Update_Coin(given10Coin);
        Destroy(gameObject);

        coco.rewardClicked();
    }
}
