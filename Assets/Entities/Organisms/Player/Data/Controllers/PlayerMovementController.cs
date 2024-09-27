using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Controls controls;
    private Movement movement;


    private void Awake()
    {
        controls = new Controls();
        movement = FindObjectOfType<Movement>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        controls.Player.Walk.performed += _ => movement.GetDirection(controls);
        controls.Player.Walk.canceled += _ => movement.ResetMovement();

    }

    private void OnEnable()
    {

        controls.Enable();

        controls.Player.Walk.performed -= _ => movement.GetDirection(controls);
        controls.Player.Walk.canceled -= _ => movement.ResetMovement();

        movement.OnMovementChanged += Walk;
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

    private void Walk()
    {

        rb.velocity = new Vector2(movement.movementData.direction.x, movement.movementData.direction.y) * movement.movementData.speed;
    }


}