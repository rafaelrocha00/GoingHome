using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{

    [SerializeField] List<int> moneyToAdd = new List<int>();

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");
            AddMoney(other.gameObject);
            Destroy(gameObject);
        }
    }

    public void AddMoney(GameObject player)
    {
        PlayerStatus spaceShip = player.GetComponent<PlayerStatus>();
        spaceShip.money += moneyToAdd[Random.Range(0, moneyToAdd.Count)];
    }
}
