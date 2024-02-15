using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private float variacaoDaPosicaoY;
    private Vector3 posicaoDoAviao;
    private bool pontuei;
    private Pontuacao pontuacao;

    private void Start()
    {
        this.posicaoDoAviao = GameObject.FindAnyObjectByType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindAnyObjectByType<Pontuacao>();
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoDaPosicaoY, variacaoDaPosicaoY));
    }

    private void Update()
    {
        this.transform.Translate(Vector3.left * this.velocidade * Time.deltaTime);

        // Se a minha(obstaculo) posicao for menor que a posicao for menor que o do aviao entao add ponto
        if (!this.pontuei && this.transform.position.x < this.posicaoDoAviao.x)
        {
            this.pontuei = true;
            this.pontuacao.AdicionarPontos();

        }
    }

    private void OnTriggerEnter2D(Collider2D outro)
    {
        Destruir();
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);

    }
}
