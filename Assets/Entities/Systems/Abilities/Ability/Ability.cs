using UnityEngine;

public abstract class Ability : ScriptableObject {

    [SerializeField] int _cost;
    [SerializeField] float _cooldown;


    public abstract void Use(Entity user, Entity target);

}