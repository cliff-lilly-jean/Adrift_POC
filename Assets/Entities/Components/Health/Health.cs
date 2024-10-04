using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HealthData data;

    public delegate void HealthChangeEvent(float amount);
    public static HealthChangeEvent OnHealthChange;

    // Start is called before the first frame update
    void Start()
    {
        data.health = data.maxHealth;
    }

    public void ChangeHealth(float amount)
    {
        data.health += amount;

        if (data.health <= 0)
        {
            Destroy(gameObject); // remove the game object
        }

        // Invoke the event to notify subscribers of a change
        OnHealthChange?.Invoke(data.health);
    }
}
