using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slider_Size : MonoBehaviour
{
    [SerializeField] UI_PowerUp size;
    [SerializeField] SpaceShipMoviment spaceShip;
    [SerializeField] Slider slider;

    private void Update()
    {
        UpdateSlider();
    }

    void UpdateSlider()
    {
        slider.maxValue = size.GetLastPowerUp().ReturnMainValue();
        slider.value = spaceShip.transform.localScale.x;
    }
}
