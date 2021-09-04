using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_ExitGame : MonoBehaviour
{
    [SerializeField] Button button;

    void Start()
    {
        button.onClick.AddListener(ChangeScene);
    }

    public void ChangeScene()
    {
        GameManager.manager.ExitGame();
    }
}
