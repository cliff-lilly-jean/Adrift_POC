using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HealthStats healthStats;

    public delegate void HealthChangeEvent(float amount);
    public static HealthChangeEvent OnHealthChange;

    // Start is called before the first frame update
    void Start()
    {
        healthStats.health = healthStats.maxHealth;
    }

    public void ChangeHealth(float amount)
    {
        healthStats.health += amount;

        if (healthStats.health <= 0)
        {
            Destroy(gameObject); // remove the game object
        }

        // Invoke the event to notify subscribers of a change
        OnHealthChange?.Invoke(healthStats.health);
    }
}
