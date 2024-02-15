using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InterfaceGameOver : MonoBehaviour
{

    [SerializeField]
    private GameObject imagemGameOver;
    [SerializeField]
    private Text valorRecord;
    private AudioSource audioGameOver;
    private Pontuacao pontuacao;


    private void Awake()
    {
        this.audioGameOver = this.GetComponent<AudioSource>();
        this.pontuacao = GameObject.FindAnyObjectByType<Pontuacao>();
    }

    public void ShowGameOver()
    {
        // habilitar a imagem de game over
        this.imagemGameOver.SetActive(true);
        this.audioGameOver.Play();
        this.AtualizarInterfaceGrafica();
    }

    public void HideGameObver()
    {
        this.imagemGameOver.SetActive(false);
    }

    private void AtualizarInterfaceGrafica()
    {
        int record = pontuacao.GetRecord();
        this.valorRecord.text = record.ToString();
    }
}
