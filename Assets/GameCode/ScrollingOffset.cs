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
            _startPosition = transform.position;
        }

        private void Update()
        {
            var material = _renderer.material;
            var offset = material.mainTextureOffset;
            var position = transform.position;

            offset.y = 1 - Time.time % 1;
            material.mainTextureOffset = offset;

            position.y = _startPosition.y + Mathf.PingPong(Time.time, 1);
            transform.position = position;
        }
    }
}