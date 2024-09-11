using UnityEngine;

[CreateAssetMenu( menuName = "Data/Character/Character Stats")]
public class CharacterStats : ScriptableObject {

    [Header("Attributes")]
    string Name;
    int age;
    float weight;
    float height;

    [Header("Health")]
    float health;
    float maxHealth;

    [Header("Stamina")]
    float stamina;
    float maxStamina;

    [Header("Movement")]
    Vector2 direction;

    [Header("Speed")]
    float speed;
    float maxSpeed;

    [Header("Combat")]
    int attack;
    int defense;

    [Header("Aura")]
    float aura;
}