using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float currentHealth;
    public float maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        currentHealth += maxHealth;
    }

    public void ChangeHealth(float amount)
    {
        currentHealth += amount;

        if (currentHealth <= 0)
        {
            gameObject.SetActive(false); // remove the game object
        }
    }
}
