using UnityEngine;

public class Movement : MonoBehaviour
{
    public MovementData movementData;

    public delegate void MovementDelegate();
    public event MovementDelegate OnMovementChanged;

    private void Start()
    {
        movementData.speed = movementData.speedMax;
    }


    public void GetDirection(Controls controls = null)
    {

        if (controls != null)
        {
            movementData.direction = controls.Player.Walk.ReadValue<Vector2>();
        }
    }

    public void ResetMovement()
    {
        movementData.direction = Vector2.zero;
    }

}