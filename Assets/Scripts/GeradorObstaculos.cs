using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour{
    [SerializeField]
    private float tempoParaGerar = 3f;
    [SerializeField]
    private GameObject manualDeInstrucoes;
    private float cronometro;


    private void Awake(){
        this.cronometro = this.tempoParaGerar;
    }

    void Update(){
        this.cronometro -= Time.deltaTime;

        if (this.cronometro < 0) {

            GameObject.Instantiate(this.manualDeInstrucoes, this.transform.position, Quaternion.identity);
            this.cronometro = this.tempoParaGerar;

        }
    }
}
