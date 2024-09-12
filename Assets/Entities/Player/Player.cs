using UnityEngine;

[RequireComponent(typeof(Health))]
public class Player : Character
{
    private Health _health;

    void Start()
    {
        // Initialize components
        _health = GetComponent<Health>();
    }

    private void Update()
    {

        Debug.Log(_health.health);

        // Debug.Log("NAME " + stats.name);
        // Debug.Log("AGE " + stats.age);
        // Debug.Log("HEIGHT " + stats.height);
        // Debug.Log("WEIGHT " + stats.weight);
        // Debug.Log("HEALTH " + stats.health);
        // Debug.Log("STAMINA " + stats.stamina);
        // Debug.Log("ATK " + stats.attack);
        // Debug.Log("DEF " + stats.defense);
        // Debug.Log("AURA " + stats.aura);
    }
}
