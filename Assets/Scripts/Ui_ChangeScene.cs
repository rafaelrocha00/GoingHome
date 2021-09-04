using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ui_ChangeScene : MonoBehaviour
{
    [SerializeField] string newScene;
    [SerializeField] Button button;

    void Start()
    {
        button.onClick.AddListener(ChangeScene);    
    }

    public void ChangeScene()
    {
        GameManager.manager.ChangeScene(newScene);
    }


}
