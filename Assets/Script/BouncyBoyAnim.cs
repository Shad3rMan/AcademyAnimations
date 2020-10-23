using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class BouncyBoyAnim : MonoBehaviour
{
    [SerializeField] private ParticleSystem particleSystem;
    private AudioSource _audioSource;

    private void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    public void PlayParticles()
    {
        particleSystem.Play();
    }

    public void PlaySound()
    {
        _audioSource.PlayOneShot(_audioSource.clip);
    }
}
