using UnityEngine;

public class Health : Component {

    public delegate void healthChanged(float currentHealth);
    public event healthChanged OnHealthChanged;

    public delegate void death();
    public event death OnDeath;

    public void Start() {



        entity.health._currentHealth = entity.health._maxHealth;
    }

    public void takeDamage(int damageAmount) {

        // var entity = GetComponent<Entity>();

        entity.health._currentHealth -= damageAmount;
        OnHealthChanged?.Invoke(entity.health._currentHealth);

        if (entity.health._currentHealth <= 0) {

            OnDeath?.Invoke();
        }
    }

}