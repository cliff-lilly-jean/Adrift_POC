using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour {

    [SerializeField] private EntityType type;

    [System.Serializable]
    public enum EntityType
    {
        Animal,
        Celestial,
        Demon,
        Human,
        Insect
    }
}