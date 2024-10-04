using UnityEngine;

public class MovementControls : MonoBehaviour
{
    public MovementStats movementStats;
    private Movement movement;
    private Controls controls;

    private void Awake()
    {
        controls = new Controls();

    }

    private void Start()
    {
        movement = FindObjectOfType<Movement>();

        controls.Player.Walk.performed += _ => GetDirection();
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

    public void GetDirection()
    {
        movementStats.direction = controls.Player.Walk.ReadValue<Vector2>();
    }

    public void ResetMovement()
    {
        movementStats.direction = Vector2.zero;
    }
}