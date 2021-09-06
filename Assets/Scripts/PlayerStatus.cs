using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatus : MonoBehaviour
{
    public int money;
    int maxLives;
    [SerializeField]int lives;
    [SerializeField]float timeUntilDeath = 1f;
    [SerializeField] SpaceShipMoviment spaceShip;

    private void Start()
    {
        spaceShip = GetComponent<SpaceShipMoviment>();
        maxLives = lives;
        StageManager.stageManager.PlayerLostDay += ResetStatus;
    }

    public void TakeLife()
    {
        lives--;
        if(IsDead())
        {
            spaceShip.ResetVelocity();
        }
    }

    public bool IsDead()
    {
        return lives <= 0;
    }

    public void ResetStatus()
    {
        Debug.Log("Reseting status");
        lives = maxLives;
    }

    public void ImproveDefense(int newDefense)
    {
        lives = newDefense;
        maxLives = lives;
    }

    IEnumerator WarnGameOfDeath()
    {
        yield return new WaitForSeconds(timeUntilDeath);
        StageManager.stageManager.PlayerLostDay?.Invoke();
    }

    public float GetMaxLives()
    {
        return maxLives;
    }

}
