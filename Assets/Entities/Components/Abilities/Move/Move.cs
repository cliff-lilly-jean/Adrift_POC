
using UnityEngine;

public class Move : Ability {

    private void OnEnable()
    {

        MovementSystem.onMovePerformed += getMoveDirection;
        MovementSystem.onMoveCanceled += resetMoveDirection;

        MovementSystem.onForceApplied += accelerate;
        MovementSystem.onForceRemoved += decelerate;

        // Broadcast initial move
        MovementSystem.TriggerMovePropertiesUpdate(Character.moveProperties);
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
        Character.moveProperties.direction = direction;
    }

    public void resetMoveDirection() {

        // zero out the direction so that the deceleration method can run to stop the movement
        Character.moveProperties.direction = Vector2.zero;
    }

    public void accelerate() {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Add force  to the rigidbody in the movement direction multiplied by the acceleration to speed it up
        rb.AddForce(Character.moveProperties.direction * Character.moveProperties.acceleration * Character.moveProperties.force, ForceMode2D.Force);

        // If the velocity is higher than the max speed, zero it out and multiply by the max speed
        if (rb.velocity.magnitude > Character.moveProperties.speed) {
            rb.velocity = rb.velocity.normalized * Character.moveProperties.speed;
        }

        // TODO: Put in own class, ex. "Vision"
        RaycastHit2D hit = Physics2D.Raycast(rb.position, Character.moveProperties.direction, 30f);
        Debug.DrawRay(rb.position, Character.moveProperties.direction , Color.green);
    }

     public void decelerate() {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Add force  to the rigidbody in the movement direction multiplied by the negative deceleration to slow it down
        rb.AddForce(rb.velocity * -Character.moveProperties.deceleration * Character.moveProperties.force, ForceMode2D.Force);
    }
}