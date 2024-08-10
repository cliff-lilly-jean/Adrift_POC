using UnityEngine;

public static class Animations {

    // * Definition and reference to all methods and variables pertaining to animations


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


        // Check to see which animation needs to be sued based on the direction
        if ((directionY > 0.5f && directionY < 1) && (directionX > 0.5f && directionX < 1)) {

            Debug.Log(Directions.NorthEast);
            return Directions.NorthEast;

        } else if((directionY > 0.5f && directionY < 1) && (directionX < -0.5f && directionX > -1)) {

             Debug.Log(Directions.NorthWest);
             return Directions.NorthWest;

        } else if((directionY < -0.5f && directionY > -1) && (directionX < -0.5f && directionX > -1)) {

             Debug.Log(Directions.SouthWest);
             return Directions.SouthWest;

        } else if((directionY < -0.5f && directionY > -1) && (directionX > 0.5f && directionX < 1)) {

             Debug.Log(Directions.SouthEast);
             return Directions.SouthEast;

        } else if(directionY == 1) {

             Debug.Log(Directions.North);
             return Directions.North;

        } else if(directionY == -1) {

             Debug.Log(Directions.South);
            return Directions.South;

        } else if(directionX == 1) {

             Debug.Log(Directions.East);
             return Directions.East;

        } else if(directionX == -1) {

             Debug.Log(Directions.West);
             return Directions.West;
        }

        return Directions.None;
    }


    // if a direction is any variant of x direction, change animation facing direction to y animation

    public static string ChangeAnimationDirection(Directions cardinalDirection, SpriteRenderer spriteRenderer) {

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