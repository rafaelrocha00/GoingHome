using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSoundOnTrigger : MonoBehaviour
{
    [SerializeField] AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        GameManager.manager.GetComponent<AudioManager>().PlayAudioClip(clip);
    }
}
