using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public AudioClip bombSFX;

    public AudioClip estrellaSFX;

    private AudioSource _audioSource;

    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }


    public void BombExlpode()
    {
        _audioSource.PlayOneShot(bombSFX);
    }

    public void Estrella()
    {
        _audioSource.PlayOneShot(estrellaSFX);
    }
}
