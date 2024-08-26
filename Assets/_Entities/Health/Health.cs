using UnityEngine;

public class Health : MonoBehaviour {

    public HealthData healthData;

    public delegate void healthChanged(float currentHealth);
    public event healthChanged OnHealthChanged;

    public delegate void death();
    public event death OnDeath;

    public void Start() {
        healthData._currentHealth = healthData._maxHealth;
    }

    public void takeDamage(int damageAmount) {

        healthData._currentHealth -= damageAmount;
        OnHealthChanged?.Invoke(healthData._currentHealth);

        if (healthData._currentHealth <= 0) {

            OnDeath?.Invoke();
        }
    }

}