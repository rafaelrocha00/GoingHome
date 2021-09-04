using System.Collections;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public TransicaoEditor transitions;
    public Action SceneChanged;
    public static GameManager manager;


    public void ExitGame()
    {
        Application.Quit();
    }

    public void ChangeScene(string sceneName)
    {
        transitions = Camera.main.GetComponent<TransicaoEditor>();
        transitions.IniciarTransicaoFadeIN(delegate { StartCoroutineToChangeScene(sceneName); });
    }

    void StartCoroutineToChangeScene(string sceneName)
    {
        StartCoroutine(ChangeSceneAsyn(sceneName));
    }

    IEnumerator ChangeSceneAsyn(string sceneName)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneName);
        while (!operation.isDone)
        {
            yield return new WaitForSeconds(0.1f);
        }
        yield return new WaitForSeconds(1f);
        SceneChanged?.Invoke();
    }

    private void Awake()
    {
        if(manager != null && manager != this)
        {
            Destroy(gameObject);
        }
        else
        {
            manager = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
