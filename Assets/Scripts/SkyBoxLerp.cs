using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxLerp : MonoBehaviour
{
    [SerializeField] Camera currentCamera;
    [SerializeField] Gradient colorTransition;

    private void Update()
    {
        HandleLerp();
    }

    void HandleLerp()
    {
        currentCamera.backgroundColor = colorTransition.Evaluate(StageManager.stageManager.GetCurrentHeightRatio());
    }
}
