using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovementController : MonoBehaviour
{
    [SerializeField] private MovementData _movementData;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
        _movementData.speed = _movementData.speedMax;
        _rb = GetComponent<Rigidbody2D>();
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

        _rb.velocity = new Vector2(horizontal, vertical) * _movementData.speed;
    }
}
