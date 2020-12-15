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
            var offset = _renderer.sharedMaterial.mainTextureOffset;
            offset.y = 1 - Time.time % 1;
            _renderer.sharedMaterial.mainTextureOffset = offset;
            var position = transform.position;
            position.y = _startPosition.y + Mathf.PingPong(Time.time, 1);
            transform.position = position;
        }
    }
}
