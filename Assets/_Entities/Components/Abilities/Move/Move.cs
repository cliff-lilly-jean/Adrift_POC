using UnityEngine;

public class Move : MonoBehaviour {

    public MoveData moveData;

    // METHODS

    public Vector2 getMoveDirection() {

        // gets the direction to the vector2 coming from the Input Reader/Controller
       return  moveData.direction;
    }

    public void resetMoveDirection() {

        // zero out the direction so that the deceleration method can run to stop the movement
        moveData.direction = Vector2.zero;
    }

    public void accelerate(Rigidbody2D rb) {

        // Add force  to the rigidbody in the movement direction multiplied by the acceleration to speed it up
        rb.AddForce(moveData.direction * moveData.acceleration * moveData.force, ForceMode2D.Force);

        // If the velocity is higher than the max speed, zero it out and multiply by the max speed
        if (rb.velocity.magnitude > moveData.speed) {
            rb.velocity = rb.velocity.normalized * moveData.speed;
        }

        // TODO: Put in own class, ex. "Vision"
        RaycastHit2D hit = Physics2D.Raycast(rb.position, moveData.direction, 30f);
        Debug.DrawRay(rb.position, moveData.direction , Color.green);
    }

     public void decelerate(Rigidbody2D rb) {

        // Add force  to the rigidbody in the movement direction multiplied by the negative deceleration to slow it down
        rb.AddForce(rb.velocity * -moveData.deceleration * moveData.force, ForceMode2D.Force);
    }
}