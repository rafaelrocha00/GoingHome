using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI_Clock : MonoBehaviour
{
    [SerializeField]TextMeshProUGUI currentDay;

    private void Start()
    {
        StageManager.stageManager.DayPassed += UpdateDay;
    }

    public void UpdateDay(int newDay)
    {
        currentDay.text = newDay.ToString();
    }
}
