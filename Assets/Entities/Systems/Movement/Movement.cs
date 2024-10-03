using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    public float speed;
    public float maxSpeed;
    public Vector2 direction;

    private Rigidbody2D rb;
    private Controls controls;

    public delegate void MovementDelegate();
    public event MovementDelegate OnMovementChanged;

    private void Awake()
    {
        controls = new Controls();
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        // Initialize speed to max speed
        speed = maxSpeed;

        controls.Player.Walk.performed += _ => GetDirection(controls);
        controls.Player.Walk.canceled += _ => ResetMovement();

    }

    private void OnEnable()
    {

        controls.Enable();

    }

    private void OnDisable()
    {
        controls.Disable();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Walk();
    }


    public void GetDirection(Controls ctrls = null)
    {

        if (ctrls != null)
        {
            direction = ctrls.Player.Walk.ReadValue<Vector2>();
        }
        else
        {
            // TODO: Add a way to control movement for NPCs and Enemies
        }
    }

    public void ResetMovement()
    {
        direction = Vector2.zero;
    }

    private void Walk()
    {

        rb.velocity = new Vector2(direction.x, direction.y) * speed;
    }

}