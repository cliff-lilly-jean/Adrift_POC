using UnityEngine;

public abstract class Entity : MonoBehaviour {

    [Header("Class")]
    public EntityType _type;

    [Header("Name")]
    public string _name;

    [Header("Health")]
    public Health _health;
}