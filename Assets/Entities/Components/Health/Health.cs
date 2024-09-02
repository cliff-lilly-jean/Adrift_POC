using UnityEngine;

public class Health : MonoBehaviour {

    public HealthProperties health;

    public delegate void healthChanged(float currentHealth);
    public event healthChanged OnHealthChanged;

    public delegate void death();
    public event death OnDeath;

    public void Start() {

        health._currentHealth = health._maxHealth;
    }

    public void takeDamage(int damageAmount) {

        health._currentHealth -= damageAmount;
        OnHealthChanged?.Invoke(health._currentHealth);

        if (health._currentHealth <= 0) {

            OnDeath?.Invoke();
        }
    }

}