using UnityEngine;

public class SpriteController : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    // private Movement movement;
    private Vector2 direction;

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
        Debug.Log(currentAnimation);
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

        // TODO:
        if (direction.y == 1)
        {
            ChangeAnimation("Player_Walk_N");
        }
        else if (direction.y == -1)
        {
            ChangeAnimation("Player_Walk_S");
        }
        else if (direction.x == 1)
        {
            spriteRenderer.flipX = false;
            ChangeAnimation("Player_Walk_E");
        }
        else if (direction.x == -1)
        {
            spriteRenderer.flipX = true;
            ChangeAnimation("Player_Walk_E");
        }
        else if (direction.y >= 0.5 && direction.x >= 0.5)
        {
            spriteRenderer.flipX = false;
            ChangeAnimation("Player_Walk_E");
        }
        else if (direction.y <= -0.5 && direction.x >= 0.5)
        {
            spriteRenderer.flipX = false;
            ChangeAnimation("Player_Walk_E");
        }
        else if (direction.y <= -0.5 && direction.x <= -0.5)
        {
            spriteRenderer.flipX = true;
            ChangeAnimation("Player_Walk_E");
        }
        else if (direction.y >= 0.5 && direction.x <= -0.5)
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
