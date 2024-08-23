using UnityEngine;

public abstract class Entity : MonoBehaviour {

    [SerializeField] EntityType _type;
    [SerializeField] string _name;
    [SerializeField] Health _health;
}