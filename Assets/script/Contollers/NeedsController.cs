using System;
using UnityEngine;

public class NeedsController : MonoBehaviour
{
    [SerializeField] int given1Exp = 1;
    [SerializeField] int given2Exp = 3;
    [SerializeField] int given3Exp = 5;
    [SerializeField] int given1coin = 1;
    [SerializeField] int given2coin = 3;
    [SerializeField] int given3coin = 5;
    public int food,happiness, energy;
    public int foodTickRate, happinessTickRate, energyTickRate;
    public DateTime lastTimeFed,
        lastTimeHappy,
        lastTimeGainedEnergy;
        private void Awake()
        {
            Intialize( 100, 100, 100, 5, 2, 1);
        }
    public void Intialize(int food,int happiness,int energy,int foodTickRate,int happinessTickRate,int energyTickRate)
    {
        lastTimeFed = DateTime.Now;
        lastTimeHappy = DateTime.Now;
        lastTimeGainedEnergy = DateTime.Now;
        this.food = food;
        this.happiness = happiness;
        this.energy = energy;
        this.foodTickRate = foodTickRate;
        this.happinessTickRate = happinessTickRate;
        this.energyTickRate = energyTickRate;
        PetUIContoller.instance.UpdateImages(food, happiness, energy);
    }
        public void Intialize(int food,int happiness,int energy,int foodTickRate,int happinessTickRate,int energyTickRate,
        DateTime lastTimeFed, DateTime lastTimeHappy, DateTime lastTimeGainedEnergy)
        {
        this.lastTimeFed = lastTimeFed;
        this.lastTimeHappy = lastTimeHappy;
        this.lastTimeGainedEnergy = lastTimeGainedEnergy;
        this.food = food;
        this.happiness = happiness;
        this.energy = energy;
        this.foodTickRate = foodTickRate;
        this.happinessTickRate = happinessTickRate;
        this.energyTickRate = energyTickRate;
        PetUIContoller.instance.UpdateImages(food, happiness, energy);
        }
    private void Update() 
        {
            if(TimingManager.gameHourTimer < 0)
            {
                ChangeFood(-foodTickRate);
                ChangeHappiness(-happinessTickRate);
                ChangeEnergy(-energyTickRate);
                PetUIContoller.instance.UpdateImages(food, happiness, energy);
            }
        }
    public void ChangeFood(int amount)
    {
        food += amount;
        
        if(amount > 0)
        {
            lastTimeFed = DateTime.Now;
            ExpStat.instance.Update_PetEXP(given1Exp);
            Currency.instance.Update_Coin(given1coin);
        }
        if(food < 0)
        {
            PetManager.instance.Die();
        }
        else if (food > 100) food = 100;
    }
    public void ChangeHappiness(int amount)
    {
        happiness += amount;
        
        if(amount > 0)
        {
            lastTimeHappy = DateTime.Now;
            ExpStat.instance.Update_PetEXP(given2Exp);
            Currency.instance.Update_Coin(given2coin);
        }
        if(happiness < 0)
        {
             PetManager.instance.Die();
        }
         else if (happiness > 100) happiness = 100;
    }
    public void ChangeEnergy(int amount)
    {
        energy += amount;
        
        if(amount > 0)
        {
            lastTimeGainedEnergy = DateTime.Now;
            ExpStat.instance.Update_PetEXP(given3Exp);
            Currency.instance.Update_Coin(given3coin);
        }
        if(energy < 0)
        {
             PetManager.instance.Die();
        }
         else if (energy > 100) energy = 100;
    }
}   
    
