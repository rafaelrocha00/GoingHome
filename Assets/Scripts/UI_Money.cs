using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Money : MonoBehaviour
{
    PlayerStatus status;
    [SerializeField] TextMeshProUGUI money;
    [SerializeField] string moneySign;

    private void Start()
    {
        status = StageManager.stageManager.player.GetComponent<PlayerStatus>();
    }

    private void Update()
    {
        UpdateMoneyUI();
    }

    public void UpdateMoneyUI()
    {
        money.text = moneySign;
        money.text += status.money.ToString();
        money.text += ".00";
    }
}
