using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField]List<AudioSource> sources = new List<AudioSource>();

    public void PlayAudioClip(AudioClip clip)
    {
        for (int i = 0; i < sources.Count; i++)
        {
            if (sources[i].isPlaying) continue;

            sources[i].clip = clip;
            sources[i].Play();
            Debug.Log("Sound play.");
            return;
        }
    }
}
