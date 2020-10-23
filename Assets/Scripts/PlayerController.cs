using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator _animator;
    private PlayerAnimatorEvents _animEvents;

    [Header("Weapon")]
    [SerializeField] private Transform _weapon = default;
    
    [SerializeField] private Transform _weaponHolder = default;
    [SerializeField] private Transform _holster = default;
    
    [Header("Positioning")]
    [SerializeField] private Vector3 _inHandPos = default;
    [SerializeField] private Vector3 _inHandRot = default;

    [SerializeField] private Vector3 _inHolsterPos = default;
    [SerializeField] private Vector3 _inHolsterRot = default;
    
    private bool _isArmed = true;
    public bool IsArmed
    {
        get => _isArmed;
        set
        {
            _isArmed = value;
            _animator.CrossFade(value ? "Equip" : "Disarm", 0.2f);
        }
    }

    private void Start()
    {
        _animator = GetComponentInChildren<Animator>();
        _animEvents = GetComponentInChildren<PlayerAnimatorEvents>();

        _animEvents.Init(this, _animator);
    }
    
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && !_animEvents.InAction)
        {
            IsArmed = !IsArmed;
        }
    }

    public void AttachWeapon()
    {
        _weapon.parent = _weaponHolder;
        _weapon.localPosition = _inHandPos;
        _weapon.localRotation = Quaternion.Euler(_inHandRot);
    }

    public void DetachWeapon()
    {
        _weapon.parent = _holster;
        _weapon.localPosition = _inHolsterPos;
        _weapon.localRotation = Quaternion.Euler(_inHolsterRot);
    }
}
