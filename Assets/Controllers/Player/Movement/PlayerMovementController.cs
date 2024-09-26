using TMPro;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Controls controls;


    private void Awake()
    {
        controls = new Controls();
    }

    // Start is called before the first frame update
    void Start()
    {

        var movement = FindObjectOfType<Movement>();

        rb = GetComponent<Rigidbody2D>();

        controls.Player.Walk.performed += _ => movement.GetDirection(controls);
        controls.Player.Walk.canceled += _ => movement.ResetMovement();

    }

    private void OnEnable()
    {
        var movement = FindObjectOfType<Movement>();

        controls.Enable();

        controls.Player.Walk.performed -= _ => movement.GetDirection(controls);
        controls.Player.Walk.canceled -= _ => movement.ResetMovement();

        movement.OnMovementChanged += Walk; // TODO Find out how to dynamically add components/prefabs at runtime
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
        var movement = FindObjectOfType<Movement>();

        rb.velocity = new Vector2(movement.movementData.direction.x, movement.movementData.direction.y) * movement.movementData.speed;
    }


}
