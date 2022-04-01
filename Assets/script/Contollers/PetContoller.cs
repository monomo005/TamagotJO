using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PetContoller : MonoBehaviour
{
    public static PetContoller instance;
    private static float sleep = 100;
    private static float hunger = 100;
    private static float clean = 100;
    public static int Stamina =100;

    public Button Feed;
    public Button Clean;
    public Button Sleep;

    public Image BubbleHung;
    public Image Bubbledozy;
    public Image Bubbledirty;
    public Image Bubbleplay;


    [SerializeField] int pay1coin = -1;
    [SerializeField] int pay5coin = -5;
    [SerializeField] int EXP1p = 1;
    [SerializeField] int EXP2p = 2;
    [SerializeField] int EXP5p = 5;

    
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
        clean -= 2.5f * Time.deltaTime;
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

    }
    public void OnclickFood2()
    {
        hunger += 20;
        Currency.instance.Update_Coin(pay1coin);
        ExpStat.instance.Update_PetEXP(EXP2p);
        
    }
    public void OnclickFood3()
    {
        hunger += 40;
        Currency.instance.Update_Coin(pay5coin);
        ExpStat.instance.Update_PetEXP(EXP5p);
    }
    public void Onclicksleep1()
    {
        sleep += 10;
        Stamina += 1;
        ExpStat.instance.Update_PetEXP(EXP1p);
    }
    public void Onclicksleep2()
    {
        sleep += 20;
        Stamina += 2;
        Currency.instance.Update_Coin(pay1coin);
        ExpStat.instance.Update_PetEXP(EXP2p);
    }
    public void Onclicksleep3()
    {
        sleep += 50;
        Stamina += 5;
        Currency.instance.Update_Coin(pay5coin);
        ExpStat.instance.Update_PetEXP(EXP5p);
    }
    public void Onclickclean1()
    {
        clean += 10;
        ExpStat.instance.Update_PetEXP(EXP1p);
    }
    public void Onclicksclean2()
    {
        clean += 20;
        Currency.instance.Update_Coin(pay1coin);
        ExpStat.instance.Update_PetEXP(EXP2p);
    }
    public void Onclickclean3()
    {
        clean += 50;
        Currency.instance.Update_Coin(pay5coin);
        ExpStat.instance.Update_PetEXP(EXP5p);
    }
}
