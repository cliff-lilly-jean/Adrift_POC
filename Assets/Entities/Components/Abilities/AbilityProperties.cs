using UnityEngine;

[CreateAssetMenu(menuName = "Ability Properties")]
public abstract class AbilityProperties : ScriptableObject {

        [SerializeField] private string abilityName;
}