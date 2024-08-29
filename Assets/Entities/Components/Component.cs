using UnityEngine;

public abstract class Component : MonoBehaviour{

    public static Entity entity;

    private void Awake() {
        entity = GetComponent<Entity>();
    }
}