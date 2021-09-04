using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MultipleMensages : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;
    [SerializeField] List<string> possibleMensagens = new List<string>();
    int index;

    private void OnEnable()
    {
        ShowMensage();
    }

    void ShowMensage()
    {
        if(index >= possibleMensagens.Count)
        {
            return;
        }

        text.text = possibleMensagens[index];
        index++;
    }
}
