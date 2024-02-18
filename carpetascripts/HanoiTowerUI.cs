using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HanoiTowerUI : MonoBehaviour
{
    public static HanoiTowerUI uIManager;
    // Start is called before the first frame update
     [Header("Configuration Panel")]
    [SerializeField]
    private TextMeshProUGUI _disksSliderValue;
    [SerializeField]
    private Slider _disksSlider;
    [SerializeField]
    private Toggle _autoToggle;

    [Header("Playmode Indicators")]
    [SerializeField]
    private GameObject _currentMovesGO;
    [SerializeField]
    private TextMeshProUGUI _currentMovesTMP;
    [SerializeField]
    private GameObject _remainingMovesGO;
    [SerializeField]
    private TextMeshProUGUI _remainingMovesTMP;

    [Space, SerializeField]
    private GameObject _levelCompletePanel;
    [SerializeField]
    private GameObject _levelCompleteTip;

    [Space, SerializeField]
    private GameObject _menuButton;

    

    [Header("Level Complete Panel")]

    [SerializeField]
    private TextMeshProUGUI _movesText;
    [SerializeField]
    private TextMeshProUGUI _timeText;

    private void Awake()
    {
        if (uIManager == null)
            uIManager = GetComponent<HanoiTowerUI>();
    }

    private void Start()
    {

    }

    #region Settings Methods
    // If slider value changes, then update its value indicator
    // and save it in PlayerPrefs
    public void UpdateDisksSliderIndicator()
    {
        _disksSliderValue.text = _disksSlider.value.ToString();

        HanoiTowerManager.HgameManager.Disks = (int)_disksSlider.value;

        PlayerPrefs.SetInt("Disks", (int)_disksSlider.value);
    }

    // If the Auto Toggle changes, then update AutoMode in
    // GameManager and save it in PlayerPrefs
    
    #endregion

    #region Playmode Methods
    // Each time the player moves a disc, update the current moves text
    public void UpdateCurrentMoves(int currentMoves)
    {
        _currentMovesTMP.text = currentMoves.ToString();
    }

    // Each time the auto player moves a disc, update the remaining moves
    public void UpdateRemainingMoves(int remainingMoves)
    {
        _remainingMovesTMP.text = "Remaining: " + remainingMoves.ToString();
    }

    public void ActivatePlaymodeUI()
    {
        _currentMovesGO.SetActive(true);

      
    }

    public void ShowLevelCompletePanel()
    {
        SetLevelCompleteStats();

       if (IsTheFirstLevelComplete())
            _levelCompleteTip.SetActive(true);
       else
            Invoke ("TorreCompleta", 2f);
    }

    public void SetLevelCompleteStats()
    {
        _movesText.text = HanoiTowerManager.HgameManager.CurrentMoves.ToString();
        _timeText.text = HanoiTowerManager.HgameManager.GetPlayTime();
    }

    public void HidePlaymodeUI()
    {
        _currentMovesGO.SetActive(false);
        _menuButton.SetActive(false);

        
    }

    
    #endregion

    private bool IsTheFirstLevelComplete()
    {
        int isTheFirstTime = PlayerPrefs.GetInt("IsTheFirstTime", 0);

        if (isTheFirstTime == 0)
        {
            PlayerPrefs.SetInt("IsTheFirstTime", 1);
            return true;
        }
        else
        {
            return false;
        }
    }

    void TorreCompleta()
    { 
        _levelCompletePanel.SetActive(true);
    }
}
