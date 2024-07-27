using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Abilities/Move")]
public class Move : Ability {

    [Header("Direction")]
     public Vector2Variable _direction;

    [Header("Speed")]
     public FloatVariable _maxSpeed;
     public FloatVariable _speed;

    [Header("Velocity")]
     public FloatVariable _acceleration;
     public FloatVariable _deceleration;

    [Header("Force")]
     public FloatVariable _force;

    public override void Use()
    {
        // Null
    }
}