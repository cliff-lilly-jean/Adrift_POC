using UnityEngine;

public abstract class Ability : ScriptableObject {

    [Header("Ability")]
    [SerializeField] public string abilityName;
    [SerializeField] public AbilityType abilityType;
    [SerializeField] public float cooldown;
}