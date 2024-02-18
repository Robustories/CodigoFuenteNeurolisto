using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace LevelUnlockSystem
{
    public class GameUI : MonoBehaviour
    {
        [SerializeField] private Color lockColor, unlockColor;
        [SerializeField] private Text levelStatusText;
        [SerializeField] private GameObject overPanel;

        public void GameOver(int starCount)
        {
            if(starCount > 0)
            {
                levelStatusText.text = "Level" + (LevelSystemManager.Instance.CurrentLevel +1) + "Completed";
                //LevelSystemManager.Instance.LevelComplete;

            }
            else
            {
                levelStatusText.text = "Level" + (LevelSystemManager.Instance.CurrentLevel +1) + "Failed";

            }

        }

        public void OkBtn()
        {
            SceneManager.LoadScene(0);
        
        }
    }


}
