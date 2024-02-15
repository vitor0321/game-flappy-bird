using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour
{
    [SerializeField]
    private Text textoPontuacao;
    private int pontos;
    private AudioSource audioPontuacao;

    private void Awake()
    {
        this.audioPontuacao = this.GetComponent<AudioSource>();
    }

    public void AdicionarPontos()
    {
        this.pontos++;
        this.textoPontuacao.text = this.pontos.ToString();
        this.audioPontuacao.Play();
    }

    public void Reiniciar()
    {
        this.pontos = 0;
        this.textoPontuacao.text = this.pontos.ToString();
    }

    public void SalvarRecord()
    {
        int recordAtual = GetRecord();
        if (recordAtual < this.pontos)
        {
            PlayerPrefs.SetInt("record", this.pontos);
        }
    }

    public int GetRecord()
    {
        return PlayerPrefs.GetInt("record");
    }
}
