using UnityEngine;

public class Move : MonoBehaviour
{
    public delegate void OnMove(Vector2 direction);
    public static event OnMove move;

    public static void OnMovePerformed(Vector2 direction)
    {
        move?.Invoke(direction);
    }

}