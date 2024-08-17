using UnityEngine;

[CreateAssetMenu(fileName = "CharacterStats", menuName = "Data/CharacterStats")]
public class CharacterStats : ScriptableObject {

    [Header("Speed")]
    public float speed;
    public float maxSpeed;

    [Header("Attack")]
    public int attack;

    [Header("Defense")]
    private int defense;

    [Header("Stamina")]
    private float stamina;
    private float maxStamina;

    [Header("Aura")]
    private float aura; // mana/force/spirit
}