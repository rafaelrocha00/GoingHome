using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ButtonSoundEffect : MonoBehaviour
{
    AudioManager manager;
    [SerializeField] AudioClip clip;

    void Start()
    {
        manager = GameManager.manager.GetComponent<AudioManager>();
        GetComponent<Button>().onClick.AddListener(PlayClip);
    }

    void PlayClip()
    {
        manager.PlayAudioClip(clip);
    }


}
