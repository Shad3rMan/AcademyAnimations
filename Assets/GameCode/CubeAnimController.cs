using UnityEngine;

[RequireComponent(typeof(Animation))]
public class CubeAnimController : MonoBehaviour
{
    private Animation _animation;

    private void Awake()
    {
        _animation = GetComponent<Animation>();
    }
    
    void Update()
    {
        if (!Input.GetMouseButtonDown(0)) return;
        _animation[_animation.clip.name].speed *= -1;
    }
}
