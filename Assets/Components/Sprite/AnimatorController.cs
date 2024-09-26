using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [Header("Animations")]
    private Animator animator;

    private string currentAnimation = "";

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();

        ChangeAnimation("Player_Death");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentAnimation);
    }

    private void ChangeAnimation(string animation, float crossFadeAmount = 0.2f)
    {
        if (currentAnimation != animation)
        {
            // Update current animation
            currentAnimation = animation;

            // Play current animation
            animator.CrossFade(animation, crossFadeAmount);
        }
    }
}
