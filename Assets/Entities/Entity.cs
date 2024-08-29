using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

    public HealthProperties health;
    public StaminaProperties stamina;
    public EntityType type;

    [System.Serializable]
    public enum EntityType
    {
        Animal,
        Celestial,
        Demon,
        Human,
        Insect
    }

    public List<AbilityProperties> abilities;
}