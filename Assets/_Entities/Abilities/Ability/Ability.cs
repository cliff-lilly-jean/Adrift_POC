using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject {

    [Header("Attributes")]
    public StringVariable Name;
    public StringVariable description;

    [Header("Energy Cost")]
    public FloatVariable energyCost;

    [Header("Cooldown")]
    public FloatVariable cooldown;

    [System.Serializable]
    public enum Type {
        Movement,
        Melee,
        Ki
    }

    [Header("Type")]
    [SerializeField] public Type type;

}