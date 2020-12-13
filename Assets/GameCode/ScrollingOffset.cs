using UnityEngine;

namespace GameCode
{
    public class ScrollingOffset : MonoBehaviour
    {
        private Renderer _renderer;
        private Vector3 _startPosition;
        private Material _material;
        private Transform _transform;
        private Vector2 _offset;
        private Vector3 _position;

        private void Awake()
        {
            _renderer = GetComponent<Renderer>();
            _startPosition = transform.position;
            _offset = _renderer.sharedMaterial.mainTextureOffset;
        }

        private void Update()
        {
            _offset.y = 1 - Time.time % 1;
            _renderer.sharedMaterial.mainTextureOffset = _offset;
            _position = transform.position;
            _position.y = _startPosition.y + Mathf.PingPong(Time.time, 1);
            transform.position = _position;
        }
    }
}
