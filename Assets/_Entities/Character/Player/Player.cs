using UnityEngine;
using System;

public class Player : Character, IMove, IDash, IAttack, IInteract
{

    // Define events for each action
    public event Action<Vector2> OnMove;
    public event Action<Vector2> OnDash;
    public event Action<GameObject> OnInteract;
    public event Action<GameObject> OnAttack;

    public void Move(Vector2 direction)
    {
        // Invoke the Move event
        OnMove?.Invoke(direction);
    }

    public void Dash(Vector2 direction)
    {
        // Invoke the Dash event
        OnDash?.Invoke(direction);
    }

    public void Interact(GameObject gameobject)
    {
        // Invoke the Interact event
        OnInteract?.Invoke(gameobject);
    }

    public void Attack(GameObject gameobject)
    {
        // Invoke the Attack event
        OnAttack?.Invoke(gameobject);
    }
}