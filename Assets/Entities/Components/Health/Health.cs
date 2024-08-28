using UnityEngine;

public class Health : MonoBehaviour {

    public delegate void healthChanged(float currentHealth);
    public event healthChanged OnHealthChanged;

    public delegate void death();
    public event death OnDeath;

    public void Start() {

        Component.entity.health._currentHealth = Component.entity.health._maxHealth;
    }

    public void takeDamage(int damageAmount) {

        // var Component.entity = GetComponent<Entity>();

        Component.entity.health._currentHealth -= damageAmount;
        OnHealthChanged?.Invoke(Component.entity.health._currentHealth);

        if (Component.entity.health._currentHealth <= 0) {

            OnDeath?.Invoke();
        }
    }

}