using UnityEngine;

[CreateAssetMenu(fileName = "Stats", menuName = "Data/Stats")]
public class Stats : ScriptableObject {

    [Header("Speed")]
    public float speed;
    public float maxSpeed;
    public float acceleration;
    public float deceleration;
    public float force;

    [Header("Attack")]
    public int attack;

    [Header("Defense")]
    public int defense;

    [Header("Stamina")]
    public float stamina;
    public float maxStamina;

    [Header("Aura")]
    public float aura; // mana/force/spirit

    [Header("Direction")]
    public Vector2 direction;
}