using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDeath : MonoBehaviour
{
    ParticleSystem particle;

    void Start()
    {
        particle = GetComponent<ParticleSystem>();
    }

    private void Update()
    {
        HandleDeath();
    }

    void HandleDeath()
    {
        if (!particle.IsAlive())
        {
            Destroy(gameObject);
        }
    }

}
