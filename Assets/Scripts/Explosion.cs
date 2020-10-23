using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;

    private void PlayEffect()
    {
        _particleSystem.Play();
    }
}
