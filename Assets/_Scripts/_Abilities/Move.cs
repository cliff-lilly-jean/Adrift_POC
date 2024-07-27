using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Abilities/Move")]
public class Move : Ability {

    [SerializeField] private Vector2Variable _direction;
    [SerializeField] private FloatVariable _maxSpeed;
    [SerializeField] private FloatVariable _speed;
    [SerializeField] private FloatVariable _acceleration;
    [SerializeField] private FloatVariable _deceleration;

    public override void Use()
    {
        // Null
    }
}