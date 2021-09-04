using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxLerp : MonoBehaviour
{
    [SerializeField] Camera currentCamera;
    [SerializeField] Color initColor;
    [SerializeField] Color finalColor;

    private void Update()
    {
        HandleLerp();
    }

    void HandleLerp()
    {
        Debug.Log(StageManager.stageManager.GetCurrentHeightRatio());
        currentCamera.backgroundColor = Color.Lerp(initColor, finalColor, StageManager.stageManager.GetCurrentHeightRatio());
    }
}
