using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public AbilityData abilityData;
    public AbilityType abilityType;

    [System.Serializable]
    public enum AbilityType // TODO: Can we have an enum of Classes
    {
        None,
        MovementAbility,
        AuraAbility
    }

    public abstract void Use();
}