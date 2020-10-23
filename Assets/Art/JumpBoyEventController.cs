using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Animation))]
public class JumpBoyEventController : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystemStartJump;
    [SerializeField] private ParticleSystem _particleSystemOnFly;

    private void OnJump()
    {
        _particleSystemStartJump.Play();
        _particleSystemOnFly.Play();
    }
    
}
