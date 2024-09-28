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

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log(currentAnimation);
        // CheckAnimation();
    }

    private void ChangeAnimation(string animation, float crossFadeAmount = 0.0005f)
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

    //     var movement = FindObjectOfType<Movement>();
    //     var sprite = FindObjectOfType<Sprite>();


    //     if (movement.movementData.direction.y == 1)
    //     {
    //         ChangeAnimation("Player_Walk_N");
    //     }
    //     else if (movement.movementData.direction.y == -1)
    //     {
    //         ChangeAnimation("Player_Walk_S");
    //     }
    //     else if (movement.movementData.direction.x == 1)
    //     {
    //         sprite.spriteRenderer.flipX = false;
    //         ChangeAnimation("Player_Walk_E");
    //     }
    //     else if (movement.movementData.direction.x == -1)
    //     {
    //         sprite.spriteRenderer.flipX = true;
    //         ChangeAnimation("Player_Walk_E");
    //     }
    //     else if (movement.movementData.direction.y >= 0.5 && movement.movementData.direction.x >= 0.5)
    //     {
    //         sprite.spriteRenderer.flipX = false;
    //         ChangeAnimation("Player_Walk_E");
    //     }
    //     else if (movement.movementData.direction.y <= -0.5 && movement.movementData.direction.x >= 0.5)
    //     {
    //         sprite.spriteRenderer.flipX = false;
    //         ChangeAnimation("Player_Walk_E");
    //     }
    //     else if (movement.movementData.direction.y <= -0.5 && movement.movementData.direction.x <= -0.5)
    //     {
    //         sprite.spriteRenderer.flipX = true;
    //         ChangeAnimation("Player_Walk_E");
    //     }
    //     else if (movement.movementData.direction.y >= 0.5 && movement.movementData.direction.x <= -0.5)
    //     {
    //         sprite.spriteRenderer.flipX = true;
    //         ChangeAnimation("Player_Walk_E");
    //     }
    //     else
    //     {
    //         ChangeAnimation("Player_Idle");
    //     }
    // }
}