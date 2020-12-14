using UnityEngine;

namespace GameCode
{
    [RequireComponent(typeof(Animation))]
    public class JumpingCubeView : MonoBehaviour
    {
        [SerializeField] private new ParticleSystem particleSystem = default;
        
        private Animation _animation;

        private void Awake()
        {
            _animation = GetComponent<Animation>();
        }

        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
                _animation[_animation.clip.name].speed *= -1;
        }

        private void PlayPuff()
        {
            particleSystem.Play();
        }
    }
}
