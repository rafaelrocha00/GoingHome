using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI_PowerUp : MonoBehaviour
{
    PlayerStatus status;
    Item currentPowerUp;
    int index;
    [SerializeField] List<Item> powerUps = new List<Item>();
    [SerializeField] Button buyButton;
    [SerializeField] TextMeshProUGUI itemPrice;
    [SerializeField] Image itemIcone;
    [SerializeField] GameObject disabledPainel;

    private void Start()
    {
        status = StageManager.stageManager.player.GetComponent<PlayerStatus>();
        index = 0;
        currentPowerUp = powerUps[index];
        buyButton.onClick.AddListener(BuyPowerUp);
    }

    private void Update()
    {
        UpdateUI();
    }

    public void BuyPowerUp()
    {
        if(status.money < currentPowerUp.GetPrice())
        {
            return;
        }

        currentPowerUp.Upgrade(StageManager.stageManager.player);
        status.money -= currentPowerUp.GetPrice();
        index++;
        if (index >= powerUps.Count)
        {
            buyButton.enabled = false;
            disabledPainel.SetActive(true);
            return;
        }

        currentPowerUp = powerUps[index];
    }

    public void UpdateUI()
    {
        itemPrice.text = "$";
        itemPrice.text += currentPowerUp.GetPrice().ToString();
        itemPrice.text += ".00";
        itemIcone.sprite = currentPowerUp.GetSprite();
        if (status.money < currentPowerUp.GetPrice())
        {
            disabledPainel.SetActive(true);
        }
        else
        {
            disabledPainel.SetActive(false);
        }
    }

    public Item GetLastPowerUp()
    {
        return powerUps[powerUps.Count - 1];
    }
}
