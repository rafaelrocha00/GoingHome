using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSceneAfterWining : MonoBehaviour
{
    [SerializeField] string newSceneName;

    void Start()
    {
        StageManager.stageManager.PlayerWon += ChangeScene;
    }

    public void ChangeScene()
    {
        GameManager.manager.ChangeScene(newSceneName);
    }
 
}
