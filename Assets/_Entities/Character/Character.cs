using UnityEngine;
using System;

public abstract class Character : Entity, IMove, IInteract, IAttack, IDash {

    // Define events for each action
    public event Action<Vector2> OnMove;
    public event Action<GameObject> OnInteract;
    public event Action<GameObject> OnAttack;
    public event Action<Vector2> OnDash;

    [SerializeField] private CharacterStats _characterStats;
    [SerializeField] private CharacterType _characterType;


    [System.Serializable]
    public enum CharacterType {
        Player,
        Enemy,
        NPC,
    }


    public void Move(Vector2 direction)
    {
        // Invoke the Move event
        OnMove?.Invoke(direction);
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

    public void Dash(Vector2 direction)
    {
        // Invoke the Dash event
        OnDash?.Invoke(direction);
    }
}