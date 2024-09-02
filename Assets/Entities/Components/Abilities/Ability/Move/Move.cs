
using UnityEngine;

public class Move : Ability {

    public MoveProperties moveProperties;

    private void OnEnable()
    {

        MovementSystem.onMovePerformed += getMoveDirection;
        MovementSystem.onMoveCanceled += resetMoveDirection;

        MovementSystem.onForceApplied += accelerate;
        MovementSystem.onForceRemoved += decelerate;

        // Broadcast initial move
        MovementSystem.TriggerMovePropertiesUpdate(moveProperties);
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
        moveProperties.direction = direction;
    }

    public void resetMoveDirection() {

        // zero out the direction so that the deceleration method can run to stop the movement
        moveProperties.direction = Vector2.zero;
    }

    public void accelerate() {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Add force  to the rigidbody in the movement direction multiplied by the acceleration to speed it up
        rb.AddForce(moveProperties.direction * moveProperties.acceleration * moveProperties.force, ForceMode2D.Force);

        // If the velocity is higher than the max speed, zero it out and multiply by the max speed
        if (rb.velocity.magnitude > moveProperties.speed) {
            rb.velocity = rb.velocity.normalized * moveProperties.speed;
        }

        // TODO: Put in own class, ex. "Vision"
        RaycastHit2D hit = Physics2D.Raycast(rb.position, moveProperties.direction, 30f);
        Debug.DrawRay(rb.position, moveProperties.direction , Color.green);
    }

     public void decelerate() {

        Rigidbody2D rb = GetComponent<Rigidbody2D>();

        // Add force  to the rigidbody in the movement direction multiplied by the negative deceleration to slow it down
        rb.AddForce(rb.velocity * -moveProperties.deceleration * moveProperties.force, ForceMode2D.Force);
    }





    public void handleMove() {
        if (moveProperties.direction == null) return;

        if(moveProperties.direction != Vector2.zero) {
            MovementSystem.TriggerForceApplied();
        }else {
            MovementSystem.TriggerForceRemoved();
        }
     }



}