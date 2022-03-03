using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    public static Exercise instance;
    [SerializeField] GameObject Panel_Exercise;
    private void Awake() 
    {
        instance = this;
    }
    void Start()
    {
        
    }

    public void Click_ToExercise()
    {
        Enable_ExercisePanel();
    }
    public void Click_Toback()
    {
        Disable_ExercisePanel();
    }
    void Enable_ExercisePanel() 
    {
           Panel_Exercise.SetActive(true);
           
    }
    void Disable_ExercisePanel()
    {
           Panel_Exercise.SetActive(false);
           
    }
}
