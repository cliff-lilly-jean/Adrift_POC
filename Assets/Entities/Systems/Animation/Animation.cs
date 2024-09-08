using UnityEngine;

public class Animation : MonoBehaviour {

    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void ChangeAnimation(string animationState)
    {
        animator.Play(animationState);
    }
}