using UnityEngine;

public class JumpingCube : MonoBehaviour
{
    [SerializeField] private Animator _animator = default;
    [SerializeField] private ParticleSystem _landingEffect = default;

    private Material _currentMaterial; 
    
    private void Start()
    {
        _animator = GetComponent<Animator>();
        _currentMaterial = GetComponent<MeshRenderer>().material;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.Play("Jump");
        }
    }

    public void PlayLandingEffect()
    {
        Debug.Log("[Animation Event] Play landing effect");
        _landingEffect.Play();
    }

    public void ChangerColor()
    {
        _currentMaterial.color = Random.ColorHSV();
    }
}
