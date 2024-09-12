using UnityEngine;

public class Player : Character
{


    void Start()
    {
        // Initialize components
    }

    private void Update()
    {

        Debug.Log("NAME " + stats.name);
        Debug.Log("AGE " + stats.age);
        Debug.Log("HEIGHT " + stats.height);
        Debug.Log("WEIGHT " + stats.weight);
        Debug.Log("HEALTH " + stats.health);
        Debug.Log("STAMINA " + stats.stamina);
        Debug.Log("ATK " + stats.attack);
        Debug.Log("DEF " + stats.defense);
        Debug.Log("AURA " + stats.aura);
    }
}
