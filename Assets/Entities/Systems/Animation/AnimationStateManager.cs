using UnityEngine;

public class AnimationStateManager : MonoBehaviour {

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void SetAnimation(string animationName)
    {
        animator.Play(animationName);
    }
}