using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetContoller : MonoBehaviour
{
    public GameObject Mong;
    public static PetContoller instance;
    private static float sleep = 100;
    private static float hunger = 100;
    private static float clean = 100;
    public static int Stamina =100;

    public Currency currencyCoin;

    public ExpStat exp;

    public bool isHaveMoney;

    public Button Hotdog, Pizza;
    public Button Nap, Slumber;
    public Button Shampoo, TakeBath;

    public Image BubbleHung;
    public Image Bubbledozy;
    public Image Bubbledirty;
    public Image Bubbleplay;

    [SerializeField] int pay1coin = -5;
    [SerializeField] int pay5coin = -20;
    [SerializeField] int EXP1p = 1;
    [SerializeField] int EXP2p = 2;
    [SerializeField] int EXP5p = 5;

    [SerializeField] GameObject exps1;
    [SerializeField] GameObject exps2;
    [SerializeField] GameObject exps5;
    [SerializeField] GameObject coins1;
    [SerializeField] GameObject coins5;

    public Animator coin1;
    public Animator coin5;
    public Animator exp1;
    public Animator exp2;
    public Animator exp3;


    public Spawner spawner;
    public Spawner2 spawner2;
    public Spawner3 spawner3;

    [SerializeField] bool checkFood1Spawn = false;
    [SerializeField] bool checkFood2Spawn = false;
    [SerializeField] bool checkFood3Spawn = false;
    
    private void Awake() 
    {
        instance = this;
    }
    void Start()
    {
        BubbleHung.CrossFadeAlpha(0,0.001f, true);
        Bubbledozy.CrossFadeAlpha(0,0.001f, true);
        Bubbledirty.CrossFadeAlpha(0,0.001f, true);
        Bubbleplay.CrossFadeAlpha(0,0.001f, true);

        
        currencyCoin.GetComponent<Currency>();

        isHaveMoney = true;
        exps1.SetActive(false);
        exps2.SetActive(false);
        exps5.SetActive(false);
        coins1.SetActive(false);
        coins5.SetActive(false);      

        spawner.GetComponent<Spawner>();
        spawner2.GetComponent<Spawner2>();
        spawner3.GetComponent<Spawner3>();
    }

    
    private void Update()
    {
        //Sleep เวลาที่ต้องการนอนที่ลดลงต่อวินาที
        sleep -= 2.75f * Time.deltaTime;
        if(sleep > 100)
        {
            sleep = 100;
        }
        if(sleep < 0)
        {
            sleep = 0;
        }
        //hunger เวลาที่ความหิวลดลงต่อวินาที
        hunger -= 3f * Time.deltaTime;
        if(hunger > 100)
        {
            hunger = 100;
        }
        if(hunger < 0)
        {
            hunger = 0;
        }
        //clean เวลาที่อยากอาบน้ำลดลงต่อวินาที
        clean -= 1f * Time.deltaTime * 60f;
        if(clean > 100)
        {
            clean = 100;
        }
        if(clean < 0)
        {
            clean = 0;
        }
        needsCheck();
        if(Stamina <0)
        {
            Stamina = 0;
        }
        if(Stamina > 100)
        {
            Stamina = 100;
        }

        if (currencyCoin.GetComponent<Currency>().Coin == 0)
        {
            isHaveMoney = false;
            
            Pizza.interactable = false;
            Hotdog.interactable = false;

            Nap.interactable = false;
            Slumber.interactable = false;

            TakeBath.interactable = false;
            Shampoo.interactable = false;
        }

        else 
        {
            isHaveMoney = true;
            Pizza.interactable = true;
            Hotdog.interactable = true;

            Nap.interactable = true;
            Slumber.interactable = true;

            TakeBath.interactable = true;
            Shampoo.interactable = true;
        }

        if (coin1.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !coin1.IsInTransition(0))
        {
            coins1.SetActive(false);
        }

        if (coin5.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !coin5.IsInTransition(0))
        {
            coins5.SetActive(false);
        }

        if (exp1.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !exp1.IsInTransition(0))
        {
            exps1.SetActive(false);
        }

        if (exp2.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !exp2.IsInTransition(0))
        {
            exps2.SetActive(false);
        }

        if (exp3.GetCurrentAnimatorStateInfo(0).normalizedTime > 1 && !exp3.IsInTransition(0))
        {
            exps5.SetActive(false);
        }
   
       if(checkFood1Spawn == true)
       {
            Spawner.instance.SpawnIt();
            spawner.enabled = true;
            checkFood1Spawn = false;
       }

       if(checkFood1Spawn == false)
       {
           spawner.enabled = false;
       }

       if(checkFood2Spawn == true)
       {
            Spawner2.instance.SpawnIt();
            spawner2.enabled = true;
            checkFood2Spawn = false;
       }

       if(checkFood2Spawn == false)
       {
           spawner2.enabled = false;
       }

       if(checkFood3Spawn == true)
       {
            Spawner3.instance.SpawnIt();
            spawner3.enabled = true;
            checkFood3Spawn = false;
       }

       if(checkFood3Spawn == false)
       {
           spawner3.enabled = false;
       }
       
    }


    private void needsCheck()
    {
        if(hunger <= 50)
        {
            BubbleHung.CrossFadeAlpha(1, 0.5f, true);
        } else
        {
            BubbleHung.CrossFadeAlpha(0, 0.5f, true);
        }
        if(sleep <= 10)
        {
            Bubbledozy.CrossFadeAlpha(1, 0.5f, true);
        } else
        {
            Bubbledozy.CrossFadeAlpha(0, 0.5f, true);
        }
        if(clean <= 30)
        {
            Bubbledirty.CrossFadeAlpha(1, 0.5f, true);
        } else
        {
            Bubbledirty.CrossFadeAlpha(0, 0.5f, true);
        }
        if(Stamina <= 75)
        {
            Bubbleplay.CrossFadeAlpha(1, 0.5f, true);
        } else
        {
            Bubbleplay.CrossFadeAlpha(0, 0.5f, true);
        }
        if(Stamina <= 50)
        {
            Bubbleplay.CrossFadeAlpha(1, 0.5f, true);
        } else
        {
            Bubbleplay.CrossFadeAlpha(0, 0.5f, true);
        }
        if(Stamina <= 25)
        {
            Bubbleplay.CrossFadeAlpha(1, 0.5f, true);
        } else
        {
            Bubbleplay.CrossFadeAlpha(0, 0.5f, true);
        }
    }
    public void OnclickFood1()
    {
       hunger += 10;
       ExpStat.instance.Update_PetEXP(EXP1p);
       exps1.SetActive(true);
        Mong.GetComponent<Animator>().Play("Eat");
       checkFood1Spawn = true;

        exp1.SetTrigger("Active");
        
        
    }
    public void OnclickFood2()
    {
        //เช็คว่ามีเงินไหม ถ้าไม่มี ไม่เรียก script เพิ่ม exp และ ความหิว
        if (isHaveMoney == true)
        {
            hunger += 20;
            currencyCoin.GetComponent<Currency>().Update_Coin(pay1coin);
            ExpStat.instance.Update_PetEXP(EXP2p);
            exps2.SetActive(true);
            coins1.SetActive(true);
            checkFood2Spawn = true;
            Mong.GetComponent<Animator>().Play("Eat");
            exp2.SetTrigger("Active");
            coin1.SetTrigger("Active");
            
            
        }
    }
    public void OnclickFood3()
    {
        //เช็คว่ามีเงินไหม ถ้าไม่มี ไม่เรียก script เพิ่ม exp และ ความหิว
        if (isHaveMoney == true)
        {
            hunger += 40;
            currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
            ExpStat.instance.Update_PetEXP(EXP5p);
            exps5.SetActive(true);
            coins5.SetActive(true);
            checkFood3Spawn = true;
            Mong.GetComponent<Animator>().Play("Eat");
            exp3.SetTrigger("Active");
            coin5.SetTrigger("Active");
            
           
        }
    }
    public void Onclicksleep1()
    {
        sleep += 10;
        Stamina += 1;
        ExpStat.instance.Update_PetEXP(EXP1p);
        exps1.SetActive(true);
        Mong.GetComponent<Animator>().Play("SpinHead");
        exp1.SetTrigger("Active");
    }
    public void Onclicksleep2()
    {
        //เช็คว่ามีเงินไหม ถ้าไม่มี ไม่เรียก script เพิ่ม exp และ ความหิว
        if (isHaveMoney == true)
        {
            sleep += 20;
            Stamina += 2;
            currencyCoin.GetComponent<Currency>().Update_Coin(pay1coin);
            ExpStat.instance.Update_PetEXP(EXP2p);
            exps2.SetActive(true);
            coins1.SetActive(true);
            Mong.GetComponent<Animator>().Play("SpinHead");
            exp2.SetTrigger("Active");
            coin1.SetTrigger("Active");
        }
    }
    public void Onclicksleep3()
    {
        //เช็คว่ามีเงินไหม ถ้าไม่มี ไม่เรียก script เพิ่ม exp และ ความหิว
        if (isHaveMoney == true)
        {
            sleep += 50;
            Stamina += 5;
            currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
            ExpStat.instance.Update_PetEXP(EXP5p);
             exps5.SetActive(true);
            coins5.SetActive(true);
            Mong.GetComponent<Animator>().Play("SpinHead");
            exp3.SetTrigger("Active");
            coin5.SetTrigger("Active");
        }
    }
    public void Onclickclean1()
    {
        clean += 10;
        ExpStat.instance.Update_PetEXP(EXP1p);
        exps1.SetActive(true);
        Mong.GetComponent<Animator>().Play("Shower");
        exp1.SetTrigger("Active");
    }
    public void Onclicksclean2()
    {
        //เช็คว่ามีเงินไหม ถ้าไม่มี ไม่เรียก script เพิ่ม exp และ ความหิว
        if (isHaveMoney == true)
        {            
            clean += 20;
            currencyCoin.GetComponent<Currency>().Update_Coin(pay1coin);
            ExpStat.instance.Update_PetEXP(EXP2p);
            exps2.SetActive(true);
            coins1.SetActive(true);
            Mong.GetComponent<Animator>().Play("Shower");
            exp2.SetTrigger("Active");
            coin1.SetTrigger("Active");
        }
    }
    public void Onclickclean3()
    {
        //เช็คว่ามีเงินไหม ถ้าไม่มี ไม่เรียก script เพิ่ม exp และ ความหิว
        if (isHaveMoney == true)
        {
            clean += 50;
            currencyCoin.GetComponent<Currency>().Update_Coin(pay5coin);
            ExpStat.instance.Update_PetEXP(EXP5p);
            exps5.SetActive(true);
            coins5.SetActive(true);
            Mong.GetComponent<Animator>().Play("Happy");
            exp3.SetTrigger("Active");
            coin5.SetTrigger("Active");
        }
    }
}
