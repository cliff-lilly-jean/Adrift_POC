using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Abilities/Move")]
public class Move : Ability {

    [Header("Direction")]
     public Vector2Variable _direction;

    [Header("Speed")]
     public FloatVariable _maxSpeed;
     public FloatVariable _speed;

    [Header("Velocity")]
     public FloatVariable _acceleration;
     public FloatVariable _deceleration;

    [Header("Force")]
     public FloatVariable _force;

    public override void Use()
    {
        // Null
        GetMoveDirection();
    }

    // * test method implementation

    public Vector2 GetMoveDirection() {

        // gets the direction to the vector2 coming from the Input Reader/Controller
        Debug.Log("Moving from the move class");
       return  _direction.value;
    }

    public void ResetMoveDirection() {

        // zero out the direction so that the deceleration method can run to stop the movement
        _direction.value = Vector2.zero;
    }

    public void Accelerate(Rigidbody2D _rb) {

        // Add force  to the rigidbody in the movement direction multiplied by the acceleration to speed it up
        _rb.AddForce(_direction.value * _acceleration.value * _force.value, ForceMode2D.Force);

        // If the velocity is higher than the max speed, zero it out and multiply by the max speed
        if (_rb.velocity.magnitude > _maxSpeed.value) {
            _rb.velocity = _rb.velocity.normalized * _maxSpeed.value;
        }

        // TODO: Cut the bottom code out into its own class, ex. "Vision"
        RaycastHit2D hit = Physics2D.Raycast(_rb.position, _direction.value, 10f);
        Debug.DrawRay(_rb.position, _direction.value , Color.green);
    }

     public void Decelerate(Rigidbody2D _rb) {

        // Add force  to the rigidbody in the movement direction multiplied by the deceleration to slow it down
        _rb.AddForce(_rb.velocity * -_deceleration.value * _force.value, ForceMode2D.Force);
    }
}