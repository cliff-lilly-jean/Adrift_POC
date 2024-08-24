using UnityEngine;

namespace Adrift.Utilities.Abilities.Movement {

    public static class Movement {

        // * Note: These are methods to be used on movement abilities

        public static Vector2 getMoveDirection(Vector2 direction) {

            // gets the direction to the vector2 coming from the Input Reader/Controller
        return  direction;
        }

        public static void resetMoveDirection(Vector2 direction) {

            // zero out the direction so that the deceleration method can run to stop the movement
            direction = Vector2.zero;
        }

        public static void accelerate(Rigidbody2D rb, Vector2 direction, float speed, float force) {

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

        public static void decelerate(Rigidbody2D rb, float deceleration, float force) {

            // Add force  to the rigidbody in the movement direction multiplied by the negative deceleration to slow it down
            rb.AddForce(rb.velocity * -deceleration * force, ForceMode2D.Force);
        }

    }
}