using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_AnimacaoDeSprite : MonoBehaviour
{
    Image imagem;
    [SerializeField] List<Sprite> Animacao = new List<Sprite>();
    [SerializeField] float TempoDeAni;
    int index;

    private void Start()
    {
        imagem = GetComponent<Image>();
        Ativar();
    }

    private void OnEnable()
    {
        Ativar();
    }

    private void OnDisable()
    {
        Desativar();
    }

    public void Ativar()
    {
        StartCoroutine(Animar());
    }

    public void Desativar()
    {
    }

    IEnumerator Animar()
    {
        while (true)
        {
            if(index < Animacao.Count && imagem != null)
            {
                imagem.sprite = Animacao[index];
            }

            yield return new WaitForSeconds(TempoDeAni);

            if (index >= Animacao.Count - 1)
            {
                index = 0;
            }
            else
            {
                index += 1;
            }

            Debug.Log(index);
        }
    }
}
