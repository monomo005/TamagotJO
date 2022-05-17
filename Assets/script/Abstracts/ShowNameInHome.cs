using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowNameInHome : MonoBehaviour
{
    public Text NameBox;
    void FixedUpdate()
    {
        NameBox.text = PlayerPrefs.GetString("name");
    }

    public void ResetSavedGame()
    {
        PlayerPrefs.DeleteKey("name");
    }
}
