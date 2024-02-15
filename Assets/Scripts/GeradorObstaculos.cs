using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour{
    [SerializeField]
    private float tempoParaGerarFacil;
    [SerializeField]
    private float tempoParaGerarDificil;
    [SerializeField]
    private GameObject manualDeInstrucoes;
    private float cronometro;
    private ControleDificuldade controleDificuldade;


    private void Awake()
    {
        this.cronometro = this.tempoParaGerarFacil;
    }

    private void Start()
    {
        this.controleDificuldade = GameObject.FindAnyObjectByType<ControleDificuldade>();
    }

    void Update(){
        this.cronometro -= Time.deltaTime;

        if (this.cronometro < 0) {

            GameObject.Instantiate(this.manualDeInstrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = Mathf.Lerp(
                this.tempoParaGerarFacil,
                this.tempoParaGerarDificil,
                this.controleDificuldade.Dificuldade
                );
        }
    }
}
