using System;
using UnityEngine;

namespace Script
{
    [RequireComponent(typeof(Animation))]
    public class Jumping : MonoBehaviour
    {
        private Animation _animation;
        [SerializeField] private ParticleSystem _particleSystem;

        private void Awake()
        {
            _animation = GetComponent<Animation>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                _animation[_animation.clip.name].speed *= -1;
            }
        }

        public void PlayParticles()
        {
            _particleSystem.Play();
        }
    }
}
