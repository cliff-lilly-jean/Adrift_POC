using UnityEngine;

public class MovementSystem : MonoBehaviour {

    // MOVE
    public delegate void movePerformed(Vector2 direction);
    public delegate void moveCanceled();

    public static event movePerformed onMovePerformed;
    public static event moveCanceled onMoveCanceled;

    // FORCE
    public delegate void applyForce();
    public delegate void removeForce();

    public static event applyForce onForceApplied;
    public static event removeForce onForceRemoved;

    // MOVE DATA
    public delegate void getMoveProperties(MoveProperties move);
    public static event getMoveProperties onMovePropertiesUpdate;

    // DASH
    public delegate void dashPerformed(Vector2 direction);
    public delegate void dashCanceled();

    public static event dashPerformed onDashPerformed;
    public static event dashCanceled onDashCanceled;

    // DASH DATA
    public delegate void getDashProperties(MoveProperties move);
    public static event getDashProperties onDashPropertiesUpdate;



    // MOVE METHODS
    public static void TriggerMovePerformed(Vector2 direction)
    {
        onMovePerformed?.Invoke(direction);
    }

    public static void TriggerMoveCanceled()
    {
        onMoveCanceled?.Invoke();
    }

    public static void TriggerMovePropertiesUpdated(MoveProperties move)
    {
        onMovePropertiesUpdate?.Invoke(move);
    }



    // FORCE METHODS
    public static void TriggerForceApplied()
    {
        onForceApplied?.Invoke();
    }

    public static void TriggerForceRemoved()
    {
        onForceRemoved?.Invoke();
    }

}