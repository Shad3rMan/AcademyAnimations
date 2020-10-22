using UnityEngine;

namespace GameCode
{
    [RequireComponent(typeof(Animation))] 
    public class BouncyBoyView : MonoBehaviour
    {
        [SerializeField]
        private ParticleSystem _particleSystem;

        private void PlayLanded()
        {
            _particleSystem.Play();
        }
    }
}
