using UnityEngine;

public class Ability : MonoBehaviour {

    [SerializeField] private string abilityName;

    [SerializeField] private AbilityType type;

    [SerializeField] private AbilityStrength strongAgainst;

    [System.Serializable]
    public enum AbilityType
    {
        Normal,
        Fire,
        Wind,
        Earth,
        Water
    }



    [System.Serializable]
    public enum AbilityStrength
    {
        Fire,
        Wind,
        Earth,
        Water,
        None
    }
}