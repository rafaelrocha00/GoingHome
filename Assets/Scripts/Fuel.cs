using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    [SerializeField] float fuelToAdd;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger");
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player");
            AddFuel(other.gameObject);
            Destroy(gameObject);
        }
    }

    public void AddFuel(GameObject player)
    {
        SpaceShipMoviment spaceShip = player.GetComponent<SpaceShipMoviment>();
        spaceShip.AddFuel(fuelToAdd);
    }
}
