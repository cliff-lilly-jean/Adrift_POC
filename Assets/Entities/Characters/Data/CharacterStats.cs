using UnityEngine;

[CreateAssetMenu( menuName = "Data/Character/Character Stats")]
public class CharacterStats : ScriptableObject {

    [Header("Attributes")]
    public string Name;
    public int age;
    public float weight;
    public float height;

    [Header("Health")]
    public float health;
    public float maxHealth;

    [Header("Stamina")]
    public float stamina;
    public float maxStamina;

    [Header("Movement")]
    Vector2 direction;

    [Header("Speed")]
    public float speed;
    public float maxSpeed;

    [Header("Combat")]
    public int attack;
    public int defense;

    [Header("Aura")]
    public float aura;
}