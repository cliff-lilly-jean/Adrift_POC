using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStats", menuName = "Data/CharacterStats")]
public class CharacterStats : ScriptableObject {

    [Header("Speed")]
    public float speed;
    public float maxSpeed;

    [Header("Attack")]
    public int attack;

    [Header("Defense")]
    public int defense;

    [Header("Stamina")]
    public float stamina;
    public float maxStamina;

    [Header("Aura")]
    public float aura; // mana/force/spirit
}