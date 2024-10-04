using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    public MovementStats movementStats;

    private string currentAnimation = "";

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        // movement = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {
        CheckAnimation();
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

    private void CheckAnimation()
    {

        if (movementStats.direction.y == 1)
        {
            ChangeAnimation("Player_Walk_N");
        }
        else if (movementStats.direction.y == -1)
        {
            ChangeAnimation("Player_Walk_S");
        }
        else if (movementStats.direction.x == 1)
        {
            spriteRenderer.flipX = false;
            ChangeAnimation("Player_Walk_E");
        }
        else if (movementStats.direction.x == -1)
        {
            spriteRenderer.flipX = true;
            ChangeAnimation("Player_Walk_E");
        }
        else if (movementStats.direction.y >= 0.5 && movementStats.direction.x >= 0.5)
        {
            spriteRenderer.flipX = false;
            ChangeAnimation("Player_Walk_E");
        }
        else if (movementStats.direction.y <= -0.5 && movementStats.direction.x >= 0.5)
        {
            spriteRenderer.flipX = false;
            ChangeAnimation("Player_Walk_E");
        }
        else if (movementStats.direction.y <= -0.5 && movementStats.direction.x <= -0.5)
        {
            spriteRenderer.flipX = true;
            ChangeAnimation("Player_Walk_E");
        }
        else if (movementStats.direction.y >= 0.5 && movementStats.direction.x <= -0.5)
        {
            spriteRenderer.flipX = true;
            ChangeAnimation("Player_Walk_E");
        }
        else
        {
            ChangeAnimation("Player_Idle");
        }
    }
}
