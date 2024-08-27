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
    public delegate void getMoveData(MoveData move);
    public static event getMoveData onMoveDataUpdated;

    // DASH


    // MOVE METHODS
    public static void TriggerMovePerformed(Vector2 direction)
    {
        onMovePerformed?.Invoke(direction);
    }

    public static void TriggerMoveCanceled()
    {
        onMoveCanceled?.Invoke();
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

    // MOVE DATA METHODS
    public static void TriggerMoveDataUpdated(MoveData move)
    {
        onMoveDataUpdated?.Invoke(move);
    }
}