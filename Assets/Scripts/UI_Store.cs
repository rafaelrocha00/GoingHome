using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UI_Store : MonoBehaviour
{
    [SerializeField] GameObject storeMainPainel;
    [SerializeField] Button closeStoreButton;

    private void Start()
    {
        closeStoreButton.onClick.AddListener(CloseStore);
        StageManager.stageManager.DayPassed += OpenStore;
    }

    public void OpenStore(int value)
    {
        storeMainPainel.SetActive(true);
    }

    public void CloseStore()
    {
        storeMainPainel.SetActive(false);
        StageManager.stageManager.stageIsActiveAndPlayable = true;
    }
}
