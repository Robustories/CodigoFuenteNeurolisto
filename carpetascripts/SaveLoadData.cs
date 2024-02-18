using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LevelUnlockSystem
{
    public class SaveLoadData : MonoBehaviour
    {
        public static SaveLoadData instance;

        public static SaveLoadData Instance {get => instance; }

        private void Awake()
        {
            if(instance == null)
            {
                instance = this;
                DontDestroyOnLoad(gameObject);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public void Initialize()
        {
            if(PlayerPrefs.GetInt("GameStartedFirstTime") == 1)
            {
                LoadData();
            }
            else
            {
                SaveData();
                PlayerPrefs.SetInt("GameStartedFirstTime", 1);

            }

        }

        public void SaveData()
        {
            string levelDataString = JsonUtility.ToJson(LevelSystemManager.Instance.LevelData);

            try
            {
                System.IO.File.WriteAllText(Application.persistentDataPath + "/LevelData.json", levelDataString);
                Debug.Log("Data Saved");
            }
            catch (System.Exception e)
            {
                Debug.Log("Error Saving Data" + e);
                throw;

            }
        }

        private void LoadData()
        {

            try
            {
                string levelDataString = System.IO.File.ReadAllText(Application.persistentDataPath + "/LevelData.json");
                LevelData levelData = JsonUtility.FromJson<LevelData>(levelDataString);
                if(levelData != null)
                {
                    LevelSystemManager.Instance.LevelData.levelItemArray = levelData.levelItemArray;
                    LevelSystemManager.Instance.LevelData.lastUnlockedLevel = levelData.lastUnlockedLevel;


                }
                Debug.Log("Data Loaded");
            }
            catch (System.Exception e)
            {
                Debug.Log("Error Loading Data" + e);
                throw;

            }
        }
    
    }
}
