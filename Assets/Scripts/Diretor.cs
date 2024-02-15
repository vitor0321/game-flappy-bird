using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    private Aviao aviao;
    private Pontuacao pontuacao;
    private TrilhaSonora trilhaSonora;
    private InterfaceGameOver interfaceGameOver;
    


    private void Start()
    {
        this.aviao = GameObject.FindAnyObjectByType<Aviao>();
        this.pontuacao = GameObject.FindAnyObjectByType<Pontuacao>();
        this.trilhaSonora = GameObject.FindAnyObjectByType<TrilhaSonora>();
        this.interfaceGameOver = GameObject.FindAnyObjectByType<InterfaceGameOver>();
    }

   
    public void FinalizarJogo()
    {
        Time.timeScale = 0;
        this.trilhaSonora.StopMusic();
        this.pontuacao.SalvarRecord();
        this.interfaceGameOver.ShowGameOver();
    }

    public void ReiniciarJogo()
    {
        Time.timeScale = 1;

        this.interfaceGameOver.HideGameObver();
        this.aviao.Reiniciar();
        this.DstruirObstaculos();
        this.pontuacao.Reiniciar();
        this.trilhaSonora.PlayMusic();
    }

    private void DstruirObstaculos()
    {
        Obstaculo[] obstaculos = GameObject.FindObjectsOfType<Obstaculo>();

        foreach (Obstaculo obstaculo in obstaculos)
        {
            obstaculo.Destruir();
        }
    }
}
