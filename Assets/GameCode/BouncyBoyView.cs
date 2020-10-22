using UnityEngine;

namespace Academy.Animations
{
    [RequireComponent(typeof(Animation))]
    public class BouncyBoyView : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem _particleSystemBoost;
        [SerializeField]
        private ParticleSystem _particleSystemLanding;
        
        private void JumpBoost()
        {
            _particleSystemBoost.Play();
        }

        private void JumpEnd()
        {
            _particleSystemLanding.Play();
        }
    }
}
