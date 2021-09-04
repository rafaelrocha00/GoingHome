using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Fuel : MonoBehaviour
{
    [SerializeField] UI_PowerUp fuel;
    [SerializeField] SpaceShipMoviment spaceShip;
    [SerializeField] Slider slider;

    private void Update()
    {
        UpdateSlider();
    }

    void UpdateSlider()
    {
        slider.maxValue = fuel.GetLastPowerUp().ReturnMainValue();
        slider.value = spaceShip.GetMaxFuel();
    }
}
