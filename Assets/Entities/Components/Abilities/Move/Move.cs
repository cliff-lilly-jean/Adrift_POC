
using UnityEngine;

public class Move : MonoBehaviour {

    private void OnEnable()
    {
        var entity = GetComponent<Entity>();

        MovementSystem.onMovePerformed += getMoveDirection;
        MovementSystem.onMoveCanceled += resetMoveDirection;

        MovementSystem.onForceApplied += accelerate;
        MovementSystem.onForceRemoved += decelerate;

        // Broadcast initial move
        MovementSystem.TriggerMoveDataUpdated(entity.move);
    }

    private void OnDisable()
    {
        MovementSystem.onMovePerformed -= getMoveDirection;
        MovementSystem.onMoveCanceled -= resetMoveDirection;

        MovementSystem.onForceApplied -= accelerate;
        MovementSystem.onForceRemoved -= decelerate;

    }
    // METHODS

    public void getMoveDirection(Vector2 direction) {

        var entity = GetComponent<Entity>();

        // gets the direction to the vector2 coming from the Input Reader/Controller
        entity.move.direction = direction;
    }

    public void resetMoveDirection() {

        var entity = GetComponent<Entity>();

        // zero out the direction so that the deceleration method can run to stop the movement
        entity.move.direction = Vector2.zero;
    }

    public void accelerate() {

        var entity = GetComponent<Entity>();

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Add force  to the rigidbody in the movement direction multiplied by the acceleration to speed it up
        rb.AddForce(entity.move.direction * entity.move.acceleration * entity.move.force, ForceMode2D.Force);

        // If the velocity is higher than the max speed, zero it out and multiply by the max speed
        if (rb.velocity.magnitude > entity.move.speed) {
            rb.velocity = rb.velocity.normalized * entity.move.speed;
        }

        // TODO: Put in own class, ex. "Vision"
        RaycastHit2D hit = Physics2D.Raycast(rb.position, entity.move.direction, 30f);
        Debug.DrawRay(rb.position, entity.move.direction , Color.green);
    }

     public void decelerate() {

        var entity = GetComponent<Entity>();

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Add force  to the rigidbody in the movement direction multiplied by the negative deceleration to slow it down
        rb.AddForce(rb.velocity * -entity.move.deceleration * entity.move.force, ForceMode2D.Force);
    }
}