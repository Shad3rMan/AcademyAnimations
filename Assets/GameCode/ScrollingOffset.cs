using UnityEngine;

public class ScrollingOffset : MonoBehaviour
{
    private Renderer _renderer;
    private Vector3 _startPosition;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
        _startPosition = transform.position;
    }

    private void Update()
    {
        var offset = _renderer.material.mainTextureOffset;
        offset.y = 1 - Time.time % 1;
        _renderer.material.mainTextureOffset = offset;
        var position = transform.position;
        position.y = _startPosition.y + Mathf.PingPong(Time.time, 1);
        transform.position = position;
    }
}
