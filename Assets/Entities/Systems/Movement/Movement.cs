using UnityEngine;

public class Movement : MonoBehaviour
{
    public MovementStats movementStats;
    private Rigidbody2D rb;

    public delegate void MovementDelegate();
    public event MovementDelegate OnMovementChanged;

    private void Awake()
    {
        rb = FindObjectOfType<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialize speed to max speed
        movementStats.speed = movementStats.maxSpeed;
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        Walk();
    }


    private void Walk()
    {

        rb.velocity = new Vector2(movementStats.direction.x, movementStats.direction.y) * movementStats.speed;
    }

}