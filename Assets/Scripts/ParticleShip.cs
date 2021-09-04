using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleShip : MonoBehaviour
{
    [SerializeField] List<ParticleSystem> particles;
    [SerializeField] SpaceShipMoviment spaceShip;

    private void Update()
    {
        if (!StageManager.stageManager.stageIsActiveAndPlayable) return;


        for (int i = 0; i < particles.Count; i++)
        {
            HandleParticleSystem(particles[i]);
        }

    }

    public void HandleParticleSystem(ParticleSystem particle)
    {
        if (spaceShip.HasFuel() && Input.GetMouseButton(0))
        {
            if (!particle.IsAlive())
            {
                particle.Play();
            }
        }
        else
        {
            Debug.Log("Stoping particles! " + particle.IsAlive());
            particle.Stop();
        }
    }
}
