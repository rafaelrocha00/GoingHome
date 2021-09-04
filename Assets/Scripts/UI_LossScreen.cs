using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_LossScreen : MonoBehaviour
{
    [SerializeField] GameObject lossScreen;
    [SerializeField] Button advance;

    private void Start()
    {
        StageManager.stageManager.PlayerLostDay += ShowLossScreen;
        advance.onClick.AddListener(AdvanceStage);
    }

    public void ShowLossScreen()
    {
        Time.timeScale = 0f;
        lossScreen.SetActive(true);
    }

    public void CloseLossScreen()
    {
        Time.timeScale = 1f;
        lossScreen.SetActive(false);
    }

    public void AdvanceStage()
    {
        StageManager.stageManager.ResetStage();
        StageManager.stageManager.PassDay();
        CloseLossScreen();
    }

}
