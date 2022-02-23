using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Database {
   
   private string path = Application.dataPath + "/Resource/Saves/";
   public void SaveData<T>(string saveName, T SaveData)
   {
       string jsonToSave = JsonUtility.ToJson(SaveData);
       File.WriteAllText
       (
        path+saveName+".json",
        jsonToSave
       );
   }

   public void LoadData<T>(string saveName, System.Action<T> callback)
    {
        if(File.Exists(path + saveName + ".json"))
        {
            string loadedJson = File.ReadAllText(path + saveName + ".json");
            callback(JsonUtility.FromJson<T>(loadedJson));
        }
        else    
        {
            Debug.Log("File doesn't exist");
        }
    }
}

