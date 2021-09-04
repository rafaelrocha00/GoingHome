using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_AnimacaoDeOpacidade : MonoBehaviour
{
    [SerializeField] float tempoDisponivel;
    [SerializeField] float offset;
    Image image;
    IEnumerator AnimarOpacidade()
    {
        yield return new WaitForSeconds(offset);

        float contador = 0;
        while (contador <= tempoDisponivel)
        {
            contador += Time.deltaTime;
            float opacidade = (contador / tempoDisponivel);
            image.color = new Vector4(image.color.r, image.color.g, image.color.b, opacidade);
            yield return new WaitForEndOfFrame();
        }
    }

    public void Start()
    {
        image = GetComponent<Image>();
        image.color *= new Vector4(1, 1, 1, 0);
        StartCoroutine(AnimarOpacidade());
    }
}
