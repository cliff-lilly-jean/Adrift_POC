using UnityEngine;

public class Movement : MonoBehaviour
{
    public MovementData movementData;

    public delegate void MovementDelegate();
    public event MovementDelegate OnMovementChanged;

    public Vector2 GetDirection(Controls controls = null)
    {

        if (controls != null)
        {
            return movementData.direction = controls.Player.Walk.ReadValue<Vector2>();
        }

        Debug.Log("Need to add some functionality here!!!!!!!!!!!!!!!");
        return Vector2.zero;
    }

}