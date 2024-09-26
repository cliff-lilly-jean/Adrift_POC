using UnityEngine;

public class Movement : MonoBehaviour
{
    public MovementData movementData;

    public delegate void MovementDelegate();
    public static event MovementDelegate OnMovementChanged;

}