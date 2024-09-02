using UnityEngine;

[CreateAssetMenu(menuName = "Data/Abilities/Move/Move Properties")]
public class MoveProperties : ScriptableObject {

    [Header("Direction")]
    public Vector2 direction;

    [Header("Speed")]
    public float speed;


    [Header("Velocity")]
    public float acceleration;
    public float deceleration;

    [Header("Force")]
    public float force;
}