using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animation))]
public class JumpingCubeView : MonoBehaviour
{
    [SerializeField] private ParticleSystem _particleSystem;
    private Animation _animation;

    private void Awake()
    {
        _animation = GetComponent<Animation>();
        _animation.Play();

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            _animation[_animation.clip.name].speed *= -1;
        }
    }

    public void BurstParticles()
    {
        var system = Instantiate(_particleSystem,
            new Vector3(
                transform.position.x,
                transform.position.y - 0.4f,
                transform.position.z),
                Quaternion.identity);
        system.Play();
    }
}
