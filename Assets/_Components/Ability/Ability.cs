using UnityEngine;

public abstract class Ability : MonoBehaviour {

    [Header("Ability")]
    [SerializeField] private string _abilityName;
    [SerializeField] private AbilityType _abilityType;
}