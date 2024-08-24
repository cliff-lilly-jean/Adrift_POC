using UnityEngine;

[CreateAssetMenu(menuName = "Ability/Type")]
public class AbilityType : ScriptableObject {

    public Type abilityType;

    [System.Serializable]
    public enum Type
    {
        Movement,
        Energy,
        Combat
    }

    // TODO: Create a subtype enum that checks the type, ex. elemental, celestial, normal
    // TODO: ---- if elemental,
    // ---------------- determine which element the energy is sourced from
    // TODO: ---- if celestial,
    // ---------------- determine which planet the energy is sourced from
}