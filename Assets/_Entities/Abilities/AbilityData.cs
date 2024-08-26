using UnityEngine;

[CreateAssetMenu(menuName = "Data/Ability/Ability Data")]
public class AbilityData : ScriptableObject {

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