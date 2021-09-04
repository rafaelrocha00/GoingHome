using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Speed : MonoBehaviour
{
    [SerializeField] UI_PowerUp speed;
    [SerializeField] SpaceShipMoviment spaceShip;
    [SerializeField] Slider slider;

    private void Update()
    {
        UpdateSlider();
    }

    void UpdateSlider()
    {
        slider.maxValue = speed.GetLastPowerUp().ReturnMainValue();
        slider.value = spaceShip.GetSpeed();
    }

}
