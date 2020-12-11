using UnityEngine;

namespace GameCode
{
    public class ScrollingOffset : MonoBehaviour
    {
        [SerializeField] private GameObject[] _cubes;

        private Vector3 _startPosition;

        private Transform[] _cubesTransform;
        private Material[] _cubesMaterial;

        private void Awake()
        {
            _cubesTransform = new Transform[_cubes.Length];
            _cubesMaterial = new Material[_cubes.Length];
            for (int i = 0; i < _cubes.Length; i++)
            {
                _cubesTransform[i] = _cubes[i].transform;
                _cubesMaterial[i] = _cubes[i].GetComponent<Renderer>().sharedMaterial;
            }
            _startPosition = _cubes[0].transform.position;
        }

        private void Update()
        {
            var offset = _cubesMaterial[0].mainTextureOffset;
            offset.y = 1 - Time.time % 1;


            for (int i = 0; i < _cubes.Length; i++)
            {
                _cubesMaterial[i].mainTextureOffset = offset;
                var position = _cubesTransform[i].position;
                position.y = _startPosition.y + Mathf.PingPong(Time.time, 1);
                _cubesTransform[i].position = position;
            }
        }
    }
}
