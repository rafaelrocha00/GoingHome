using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerSpawner : MonoBehaviour
{
    [SerializeField] Transform player;
    SpaceShipMoviment spaceShip;
    [SerializeField] List<GameObject> powerUpsToSpawn = new List<GameObject>();
    [SerializeField] float distanceToPlayer;
    [SerializeField] float upOffsetToPlayer;
    [SerializeField] float timeBetweenSpawn;

    private void Start()
    {
        spaceShip = player.GetComponent<SpaceShipMoviment>();
        StartCoroutine(HandleSpawnInGame());
    }

    IEnumerator HandleSpawnInGame()
    {
        while (true)
        {
            if (!StageManager.stageManager.stageIsActiveAndPlayable) yield return new WaitForEndOfFrame();

            SpawnPowerUp();
            yield return new WaitForSeconds(timeBetweenSpawn);
        }
    }

    public void SpawnPowerUp()
    {
        if (!StageManager.stageManager.stageIsActiveAndPlayable) return;
        if (spaceShip.velocity == Vector3.zero) return;

        Vector3 playerPos = player.position;
        playerPos.y += upOffsetToPlayer;

        Vector3 pos = Random.insideUnitSphere * distanceToPlayer + playerPos;
        pos.x = player.position.x;
        int randomIndex = Random.Range(0, powerUpsToSpawn.Count);
        Instantiate(powerUpsToSpawn[randomIndex], pos, powerUpsToSpawn[randomIndex].transform.rotation);
    }


}
