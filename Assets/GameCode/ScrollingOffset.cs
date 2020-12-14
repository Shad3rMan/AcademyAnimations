using UnityEngine;

namespace GameCode
{
    public class ScrollingOffset : MonoBehaviour
    {
        private Vector3 _startPosition;
        private Material _material;
        private Transform _transform;
        private Vector2 _offset;
        private Vector3 _position;

        private void Awake()
        {
            _material = GetComponent<Renderer>().sharedMaterial;
            _startPosition = transform.position;
            _offset = _material.mainTextureOffset;
        }

        private void Update()
        {
            _offset.y = 1 - Time.time % 1;
            _material.mainTextureOffset = _offset;
            _position = transform.position;
            _position.y = _startPosition.y + Mathf.PingPong(Time.time, 1);
            transform.position = _position;
        }
    }
}
