using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace LinePaint
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private Text levelText;
        [SerializeField] private GameObject mainMenu, CompleteMenu;
        [SerializeField] private Button nextButton;

        public Text LevelText {get => levelText; }

        private void Start()
        {
            nextButton.onClick.AddListener(()=> OnClick(nextButton));

        }

        private void OnClick(Button btn)
        {
            switch (btn.name)
            {
                case"NextButton":
                break;

            }
        }

        public void LevelComplete()
        {
            mainMenu.SetActive(false);
            CompleteMenu.SetActive(true);

        }


    }
}
