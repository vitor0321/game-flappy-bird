using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrilhaSonora : MonoBehaviour
{
    private AudioSource musicGame;

    private void Awake()
    {
        this.musicGame = this.GetComponent<AudioSource>();
    }

    public void StopMusic() {
        this.musicGame.Stop();
    }

    public void PlayMusic()
    {
        this.musicGame.Play();
    }
}
