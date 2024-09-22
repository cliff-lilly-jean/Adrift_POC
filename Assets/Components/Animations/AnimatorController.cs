using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    private Animator animator;
    private string currentAnimation = "";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void ChangeAnimation(string animation, float crossFadeAmount)
    {
        if (currentAnimation != animation)
        {
            // Store the new animation value in the current animation variable
            currentAnimation = animation;

            // Change the animation to the current animation at the cross fade amount
            animator.CrossFade(currentAnimation, crossFadeAmount);
        }
    }
}
