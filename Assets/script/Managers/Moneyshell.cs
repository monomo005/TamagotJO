using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moneyshell : MonoBehaviour
{
    [SerializeField] int EXP1p = 1;
    [SerializeField] int given3Coin = 3;

    public spawnShellintime shell;
    private void Start()
    {
        if (shell == null) shell = GameObject.FindGameObjectWithTag("Shell").GetComponent<spawnShellintime>();
        shell.GetComponent<spawnShellintime>();
    }
    void OnMouseDown()
    {
        Currency.instance.Update_Coin(given3Coin);
        ExpStat.instance.Update_PetEXP(EXP1p);
        //Mong.GetComponent<Animator>().Play("Happy");
        Destroy(gameObject);

        shell.rewardClicked();
    }
}
