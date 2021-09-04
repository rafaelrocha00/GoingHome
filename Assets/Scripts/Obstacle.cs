using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] GameObject damageParticle;

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
        spaceShip.TakeLife();

        if (damageParticle == null) return;
        Instantiate(damageParticle, spaceShip.transform.position, damageParticle.transform.rotation);
    }
}
