using UnityEngine;

namespace GameCode
{
    public class ScrollingOffset : MonoBehaviour
    {
        private Renderer _renderer;
        private Vector3 _startPosition;
        private Material _material;
        private Transform _transform;

        private void Awake()
        {
            _renderer = GetComponent<Renderer>();
            _material = _renderer.sharedMaterial;
            _transform = transform;
            _startPosition = _transform.position;
        }

        private void Update()
        {
            var offset = _material.mainTextureOffset;
            offset.y = 1 - Time.time % 1;
            _material.mainTextureOffset = offset;
            var position = _transform.position;
            position.y = _startPosition.y + Mathf.PingPong(Time.time, 1);
            _transform.position = position;
        }
    }
}
