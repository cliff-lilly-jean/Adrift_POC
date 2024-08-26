using UnityEngine;

[CreateAssetMenu(menuName = "Data/Ability/Ability Description")]
public class AbilityDescriptionData : ScriptableObject {

    public string abilityName;
    public Type abilityType;
    public float cooldown;


    [System.Serializable]
    public enum Type
    {
        Movement,
        Energy,
        Combat
    }
}