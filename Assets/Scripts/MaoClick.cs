using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maoclick : MonoBehaviour
{

    private SpriteRenderer image;

    private void Awake()
    {
        this.image = this.GetComponent<SpriteRenderer>();
    }


    private void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
            this.Desaparecer();
        }
    }

    private void Desaparecer()
    {
        this.image.enabled = false;
    }
}
