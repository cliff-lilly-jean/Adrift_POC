using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private MovementSystem _movementSystem;
    private Rigidbody2D _rb;

    // Start is called before the first frame update
    void Start()
    {
       // Get all the abilities in the movement system
       foreach (Ability ability in _movementSystem.movementAbilities)
       {
            // Check if there's a Move ability
            if(ability.Name.value == "Move") {
                Debug.Log("Moving");
                var move = ability;
                Debug.Log(move.description.value);
            }

            // Check if there's a Dash ability
            if(ability.Name.value == "Dash") {
                Debug.Log("Dashing");
                var dash = ability;
                Debug.Log(dash.Name.value);
            }

            // !NOTE: Possibly use a switch statement to cycle through the abilities

       }
    }

    // private void FixedUpdate()
    // {
    //     if (_movementSystem.move._direction.value == null) return;

    //     // checking the direction value
    //     if(_movementSystem.move._direction.value != Vector2.zero) {
    //         Accelerate();
    //     }else {
    //         Decelerate();
    //     }
    // }

    // private void GetMoveDirection(Vector2 direction) {

    //     // gets the direction to the vector2 coming from the Input Reader/Controller
    //     _direction.value = direction;
    // }

    // private void ResetMoveDirection() {

    //     // zero out the direction so that the deceleration method can run to stop the movement
    //     _direction.value = Vector2.zero;
    // }

    // private void Accelerate() {

    //     // Add force  to the rigidbody in the movement direction multiplied by the acceleration to speed it up
    //     _rb.AddForce(_direction.value * _acceleration.value * _forceMultiplier.value, ForceMode2D.Force);

    //     // If the velocity is higher than the max speed, zero it out and multiply by the max speed
    //     if (_rb.velocity.magnitude > _maxSpeed.value) {
    //         _rb.velocity = _rb.velocity.normalized * _maxSpeed.value;
    //     }

    //     // TODO: Cut the bottom code out into its own class, ex. "Vision"
    //     RaycastHit2D hit = Physics2D.Raycast(_rb.position, _direction.value, 10f);
    //     Debug.DrawRay(_rb.position, _direction.value , Color.green);
    // }

    //  private void Decelerate() {

    //     // Add force  to the rigidbody in the movement direction multiplied by the deceleration to slow it down
    //     _rb.AddForce(_rb.velocity * -_deceleration.value * _forceMultiplier.value, ForceMode2D.Force);
    // }
}
