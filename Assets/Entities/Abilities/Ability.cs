using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public AbilityData abilityData;

    private AbilityType abilityType;

    [System.Serializable]
    private enum AbilityType // TODO: Can we have an enum of Classes
    {
        None,
        Movement,
        Aura
    }

    public abstract void Use();
}