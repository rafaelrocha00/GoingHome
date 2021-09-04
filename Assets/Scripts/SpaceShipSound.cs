using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceShipSound : MonoBehaviour
{
    [SerializeField] SpaceShipMoviment spaceShip;
    [SerializeField] AudioSource source;

    private void Update()
    {
        if(spaceShip.HasFuel() && Input.GetMouseButton(0))
        {
            if (source.isPlaying) return;

            source.Play();
        }
        else
        {
            source.Stop();
        }
    }
}
