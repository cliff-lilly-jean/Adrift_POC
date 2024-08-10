using UnityEngine;

public static class Animations {

    // * Definition and reference to all methods and variables pertaining to animations
    private static Directions _lastDirection;

    // TODO: Create variables to be used throughout this class in the methods

    // Change the animation
    public static void ChangeAnimation(string currentAnimation, string newAnimation, Animator animator, float crossFade = 0.05f) {

        if (currentAnimation != newAnimation) {

            currentAnimation = newAnimation;

            animator.CrossFade(newAnimation, crossFade);
        }
    }



    public static Directions CheckAnimationDirection(Vector2 direction) {

        var directionY = direction.y;
        var directionX = direction.x;

        // Return a value from the Directions enum if the direction values are met
        return (directionY > 0.5f && directionY < 1 && directionX > 0.5f && directionX < 1) ? Directions.NorthEast :
           (directionY > 0.5f && directionY < 1 && directionX < -0.5f && directionX > -1) ? Directions.NorthWest :
           (directionY < -0.5f && directionY > -1 && directionX < -0.5f && directionX > -1) ? Directions.SouthWest :
           (directionY < -0.5f && directionY > -1 && directionX > 0.5f && directionX < 1) ? Directions.SouthEast :
           (directionY == 1) ? Directions.North :
           (directionY == -1) ? Directions.South :
           (directionX == 1) ? Directions.East :
           (directionX == -1) ? Directions.West :
           Directions.None;
    }


    // if a direction is any variant of x direction, change animation facing direction to y animation

    public static string ChangeAnimationDirection(Directions cardinalDirection, SpriteRenderer spriteRenderer) {

        // CHeck if there's no direction being moved in
        if (cardinalDirection == Directions.None)
        {
            // Return the idle animation based on the last movement direction
            return _lastDirection switch
            {
                Directions.North or Directions.NorthEast or Directions.NorthWest => "Idle_B",
                Directions.South or Directions.SouthEast or Directions.SouthWest => "Idle_F",
                Directions.East or Directions.West => "Idle_R",
                _ => "Idle_R" // Default idle animation
            };
        }

        // Update last direction
        _lastDirection = cardinalDirection;

        if(cardinalDirection == Directions.NorthEast || cardinalDirection == Directions.SouthEast || cardinalDirection == Directions.East) {

            spriteRenderer.flipX = false;
            return "Walk_R";
        } else if(cardinalDirection == Directions.NorthWest || cardinalDirection == Directions.SouthWest || cardinalDirection == Directions.West) {

            spriteRenderer.flipX = true;
            return "Walk_R";
        } else if(cardinalDirection == Directions.North) {
            return "Walk_B";
        } else if(cardinalDirection == Directions.South) {

            return "Walk_F";
        }

        return "";
    }


    public enum Directions {
        North,
        South,
        East,
        West,
        NorthWest,
        SouthWest,
        NorthEast,
        SouthEast,
        None
    }
}