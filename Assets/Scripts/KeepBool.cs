using UnityEngine;

public class KeepBool : StateMachineBehaviour
{
    public string boolName;
    public bool boolStatus;

    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(boolName, boolStatus);  
    }
    
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool(boolName, boolStatus);    
    }
}
