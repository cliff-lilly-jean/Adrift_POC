using UnityEngine;

public class Health : MonoBehaviour {


    public void DecreaseHealth(float currentHealth, float amountToDecrease)
    {
        currentHealth -= amountToDecrease;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void IncreaseHealth(float currentHealth, float maxHealth, float amountToIncrease)
    {
        currentHealth += amountToIncrease;

        if (currentHealth >= maxHealth)
        {
            Restored();
        }
    }

    public void FullHeal(float currentHealth, float maxHealth) {
        currentHealth = maxHealth;
        Restored();
    }

    private void Die()
    {
        Debug.Log("Player has died.");
        // Handle player death (e.g., restart level, show game over screen)
    }

    private void Restored()
    {
        Debug.Log("Player is fully healed");
        // Handle player death (e.g., restart level, show game over screen)
    }
}