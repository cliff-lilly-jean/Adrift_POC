using UnityEngine;

public class Health : MonoBehaviour {

    public delegate void healthChanged(float currentHealth);
    public event healthChanged OnHealthChanged;

    public delegate void death();
    public event death OnDeath;

    [SerializeField] float _maxHealth;
    [SerializeField] float _currentHealth;

    private void Start() {
        _currentHealth = _maxHealth;
    }

    public void takeDamage(int damageAmount) {

        _currentHealth -= damageAmount;
        OnHealthChanged?.Invoke(_currentHealth);

        if (_currentHealth <= 0) {

            OnDeath?.Invoke();
        }
    }

}