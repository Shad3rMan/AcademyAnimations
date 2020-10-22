using UnityEngine;

namespace Academy.Animations
{
    [RequireComponent(typeof(Animation))]
    public class BouncyBoyView : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem _particleSystemBoost;
        
        private void JumpBoost()
        {
            _particleSystemBoost.Play();
        }
    }
}
