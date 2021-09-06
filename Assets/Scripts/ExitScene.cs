using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScene : MonoBehaviour
{
    [SerializeField] string newSceneName;
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            GameManager.manager.ChangeScene(newSceneName);
        }
    }
}
