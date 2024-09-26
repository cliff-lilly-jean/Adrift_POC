using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    [Header("Animations")]
    private Animator animator;
    private Movement movement;

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

    // private void CheckAnimation()
    // {
    //     if (movement.y == 1)
    //     {
    //         ChangeAnimation("Player_Walk_S");
    //     }
    //     else if (movement.y == -1)
    //     {
    //         ChangeAnimation("Player_Walk_N");
    //     }
    //     else if (movement.x == 1)
    //     {
    //         ChangeAnimation("Player_Walk_E");
    //     }
    //     else
    //     {
    //         // Flip sprite
    //         ChangeAnimation("Player_Walk_E");
    //     }
    // }


    // private Vector2 GetMovementValue() {
    //     return
    // }
}
