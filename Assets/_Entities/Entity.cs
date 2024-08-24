using UnityEngine;

public abstract class Entity : MonoBehaviour {

    [Header("Class")]
    public EntityType type;

    [Header("Name")]
    public string title;

    [Header("Health")]
    public Health health;

    [Header("Direction")]
    public Vector2 direction;
}