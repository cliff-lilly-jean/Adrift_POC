
using UnityEngine;

public class Move : MonoBehaviour {


    [SerializeField] private Entity entity;

    private void OnEnable()
    {
        MovementSystem.onMovePerformed += getMoveDirection;
        MovementSystem.onMoveCanceled += resetMoveDirection;

        MovementSystem.onForceApplied += accelerate;
        MovementSystem.onForceRemoved += decelerate;

        // Broadcast initial moveData
        MovementSystem.TriggerMoveDataUpdated(entity.moveData);
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

        // gets the direction to the vector2 coming from the Input Reader/Controller
        entity.moveData.direction = direction;
    }

    public void resetMoveDirection() {

        // zero out the direction so that the deceleration method can run to stop the movement
        entity.moveData.direction = Vector2.zero;
    }

    public void accelerate() {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Add force  to the rigidbody in the movement direction multiplied by the acceleration to speed it up
        rb.AddForce(entity.moveData.direction * entity.moveData.acceleration * entity.moveData.force, ForceMode2D.Force);

        // If the velocity is higher than the max speed, zero it out and multiply by the max speed
        if (rb.velocity.magnitude > entity.moveData.speed) {
            rb.velocity = rb.velocity.normalized * entity.moveData.speed;
        }

        // TODO: Put in own class, ex. "Vision"
        RaycastHit2D hit = Physics2D.Raycast(rb.position, entity.moveData.direction, 30f);
        Debug.DrawRay(rb.position, entity.moveData.direction , Color.green);
    }

     public void decelerate() {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Add force  to the rigidbody in the movement direction multiplied by the negative deceleration to slow it down
        rb.AddForce(rb.velocity * -entity.moveData.deceleration * entity.moveData.force, ForceMode2D.Force);
    }
}