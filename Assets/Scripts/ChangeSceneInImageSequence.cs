using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneInImageSequence : MonoBehaviour
{
    [SerializeField] ImageSequence imageSequence;
    [SerializeField] string newMapName;

    private void Start()
    {
        imageSequence.FinishedShowingImageSequence += ChangeMap;
    }

    public void ChangeMap()
    {
        GameManager.manager.ChangeScene(newMapName);
    }
}
