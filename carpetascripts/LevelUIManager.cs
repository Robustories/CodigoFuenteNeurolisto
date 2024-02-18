using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LevelUnlockSystem
{
    public class LevelUIManager : MonoBehaviour
    {
        [SerializeField] private GameObject levelBtnGridHolder;
        [SerializeField] private LevelButtonScript levelBtnPrefab;

        private void Start()
        {
            InitializeUI();
        }

        public void InitializeUI()
        {
            LevelItem[] levelItemArray = LevelSystemManager.Instance.LevelData.levelItemArray;

            for (int i = 0; i <levelItemArray.Length; i++)
            {
                LevelButtonScript levelButton = Instantiate(levelBtnPrefab, levelBtnGridHolder.transform);
                levelButton.SetLevelButton(levelItemArray[i],i,i == LevelSystemManager.Instance.LevelData.lastUnlockedLevel);

            }
        }
    
    }
}
