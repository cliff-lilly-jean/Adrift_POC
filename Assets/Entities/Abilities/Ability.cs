using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public AbilityData data;
    public AbilityType type;


    [System.Serializable]
    public enum AbilityType // TODO: Can we have an enum of Classes
    {
        Dash,
        Healing,
        Stealth,
        Shield,
        Ki
    }

    void Start()
    {

    }

    public abstract void Use();

}