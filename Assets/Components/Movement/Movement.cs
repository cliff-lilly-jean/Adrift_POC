using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Movement : MonoBehaviour
{
    public MovementData movementData;
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
        movementData.speed = movementData.maxSpeed;

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
            movementData.direction = ctrls.Player.Walk.ReadValue<Vector2>();
        }
        else
        {
            // TODO: Add a way to control movement for NPCs and Enemies
        }
    }

    public void ResetMovement()
    {
        movementData.direction = Vector2.zero;
    }

    private void Walk()
    {

        rb.velocity = new Vector2(movementData.direction.x, movementData.direction.y) * movementData.speed;
    }

}