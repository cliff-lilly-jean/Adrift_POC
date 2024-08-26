using UnityEngine;

[CreateAssetMenu(menuName = "Data/Abilities/Move/Move Data")]
public class MoveData : ScriptableObject {

    [Header("Direction")]
    public Vector2 direction;

    [Header("Speed")]
    public float speed;
    public float maxSpeed;


    [Header("Velocity")]
    public float acceleration;
    public float deceleration;

    [Header("Force")]
    public float force;
}