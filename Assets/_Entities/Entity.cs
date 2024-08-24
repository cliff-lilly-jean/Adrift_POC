using UnityEngine;

public abstract class Entity : MonoBehaviour {

    [Header("Class")]
    [SerializeField] EntityType _type;

    [Header("Name")]
    [SerializeField] string _name;

    [Header("Health")]
    [SerializeField] Health _health;
}