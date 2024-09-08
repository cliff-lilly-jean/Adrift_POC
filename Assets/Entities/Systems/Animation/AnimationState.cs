using UnityEngine;

public class AnimationState : MonoBehaviour {

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ChangeAnimationState(string animationState)
    {
        animator.Play(animationState);
    }
}