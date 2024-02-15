using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControleDificuldade : MonoBehaviour
{
    [SerializeField]
    private float tempoParaDificuldadeMaxima;
    private float tempoPassado;
    public float Dificuldade { get; private set;}

    void Update()
    {
        this.tempoPassado += Time.deltaTime;

        //aqui calculamos a porcetagem da dificuldade
        this.Dificuldade = this.tempoPassado / this.tempoParaDificuldadeMaxima;
        //aqui limitamos ela até 100%, senão iria passar desse numero
        this.Dificuldade = Mathf.Min(1, this.Dificuldade);
    }
}
