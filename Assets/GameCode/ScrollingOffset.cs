using TMPro.EditorUtilities;
using UnityEngine;

namespace GameCode
{
    public class ScrollingOffset : MonoBehaviour {
        
        private Renderer _renderer;
        private Vector3 _startPosition;
        private static Material _material;
        private Transform _transform;

        private void Awake() {
            _renderer = GetComponent<Renderer>();
            _material = _renderer.material;
            _startPosition = transform.position;
            _transform = transform;
        }

        private void Update()
        {
            var offset = _renderer.material.mainTextureOffset;
            offset.y = 1 - Time.time % 1;
            _material.mainTextureOffset = offset;
            var position = transform.position;
            position.y = _startPosition.y + Mathf.PingPong(Time.time, 1);
            _renderer.sharedMaterial = _material;
            _transform.position = position;
        }
    }
}
