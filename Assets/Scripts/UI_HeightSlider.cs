using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_HeightSlider : MonoBehaviour
{
    [SerializeField] Transform player;
    Slider heightSlider;

    private void Start()
    {
        heightSlider = GetComponent<Slider>();
        heightSlider.minValue = player.position.y;
        heightSlider.maxValue = StageManager.stageManager.GetHeighToVictory();
    }

    private void Update()
    {
        UpdateSlider();
    }

    public void UpdateSlider()
    {
        heightSlider.value = player.position.y;
    }
}
