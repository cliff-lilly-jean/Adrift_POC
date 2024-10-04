using UnityEngine;

public class Movement : MonoBehaviour
{
    public MovementData data;
    private Rigidbody2D rb;

    public delegate void MovementDelegate();
    public event MovementDelegate OnMovementChanged;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialize speed to max speed
        data.speed = data.maxSpeed;

        rb = GetComponentInParent<Rigidbody2D>();
    }


    // Update is called once per frame
    private void FixedUpdate()
    {
        Walk();
    }


    private void Walk()
    {

        rb.velocity = new Vector2(data.direction.x, data.direction.y) * data.speed;
    }

}