using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Movement movement;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        movement = FindAnyObjectByType<Movement>();
    }

    private void OnEnable()
    {
        Movement.OnMovementChanged += Walk;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Walk();
    }

    private void Walk()
    {

        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(horizontal, vertical) * movement.movementData.speed;
    }
}
