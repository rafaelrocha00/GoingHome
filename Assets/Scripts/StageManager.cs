using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageManager : MonoBehaviour
{
    public bool stageIsActiveAndPlayable = true;
    public static StageManager stageManager;
    [SerializeField] float minHeightToVictory;
    float initialHeight;
    int currentDay;
    [SerializeField]int maxDayToWin;
    public SpaceShipMoviment player;
    public Action PlayerWon;
    public Action PlayerLostDay;
    public Action PlayerLostGame;
    public Action<int> DayPassed;

    private void Awake()
    {
        if(stageManager != null && stageManager != this)
        {
            Destroy(gameObject);
        }
        else
        {
            stageManager = this;
        }
    }

    private void Start()
    {
        initialHeight = player.transform.position.y;
    }

    private void Update()
    {
        CheckVictory();
        CheckLoss();
    }

    void CheckVictory()
    {
        if(player.transform.position.y >= minHeightToVictory)
        {
            Debug.Log("Player won!");
            PlayerWon?.Invoke();
        }
    }

    void CheckLoss()
    {
        if(player.transform.position.y <= initialHeight && !player.HasFuel())
        {
            PlayerLostDay?.Invoke();
        }
    }

    public float GetHeighToVictory()
    {
        return minHeightToVictory;
    }

    public float GetCurrentHeightRatio()
    {
        return player.transform.position.y /  minHeightToVictory;
    }

    public void PassDay()
    {
        currentDay++;
        if(currentDay > maxDayToWin)
        {
            PlayerLostGame?.Invoke();
            return;
        }
        DayPassed?.Invoke(currentDay);
        stageIsActiveAndPlayable = false;
    }


    public void ResetStage()
    {
        player.ResetSpaceShip();
    }

    public void StartStage()
    {
        stageIsActiveAndPlayable = true;
    }
}
