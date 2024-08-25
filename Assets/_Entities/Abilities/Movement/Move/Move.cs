using UnityEngine;

[CreateAssetMenu(menuName = "Ability/Move")]
public class Move : Ability {

    [SerializeField] public float force = 10;
    [SerializeField] public float  acceleration, deceleration = 2;

    public Vector2 getMoveDirection(Vector2 direction) {

            // gets the direction to the vector2 coming from the Input Reader/Controller
        return  direction;
        }

        public void resetMoveDirection(Vector2 direction) {

            // zero out the direction so that the deceleration method can run to stop the movement
            direction = Vector2.zero;
        }

        public void accelerate(Rigidbody2D rb, Vector2 direction, float speed) {

            // Add force  to the rigidbody in the movement direction multiplied by the acceleration to speed it up
            rb.AddForce(direction * speed * force, ForceMode2D.Force);

            // If the velocity is higher than the max speed, zero it out and multiply by the max speed
            if (rb.velocity.magnitude > speed) {
                rb.velocity = rb.velocity.normalized * speed;
            }

            // TODO: Put in own class, ex. "Vision"
            RaycastHit2D hit = Physics2D.Raycast(rb.position, direction, 30f);
            Debug.DrawRay(rb.position, direction , Color.green);
        }

        public void decelerate(Rigidbody2D rb) {

            // Add force  to the rigidbody in the movement direction multiplied by the negative deceleration to slow it down
            rb.AddForce(rb.velocity * -deceleration * force, ForceMode2D.Force);
        }

}