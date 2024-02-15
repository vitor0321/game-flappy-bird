using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour{

    [SerializeField]
    private int forca;
    private Diretor diretor;

    private Vector3 posicaoInicial;
    private bool deveImpulsionar;
    private Rigidbody2D fisica;

    private void Awake()
    {
        this.fisica = this.GetComponent<Rigidbody2D>();
        this.posicaoInicial = this.transform.position;
    }

    private void Start()
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Update()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            this.deveImpulsionar = true;
        }
    }

    private void FixedUpdate()
    {
        if (this.deveImpulsionar) {
            this.Impulsionar();
        }
    }

    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
        this.deveImpulsionar = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }
}
