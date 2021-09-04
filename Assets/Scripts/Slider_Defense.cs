using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Defense : MonoBehaviour
{
    [SerializeField] UI_PowerUp defense;
    [SerializeField] PlayerStatus spaceShip;
    [SerializeField] Slider slider;

    private void Update()
    {
        UpdateSlider();
    }

    void UpdateSlider()
    {
        slider.maxValue = defense.GetLastPowerUp().ReturnMainValue();
        slider.value = spaceShip.GetMaxLives();
    }
}
