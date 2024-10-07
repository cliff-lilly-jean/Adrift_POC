using UnityEngine;

public class DamageCalculator : MonoBehaviour
{
    private System.Random _random = new System.Random();

    // Function to calculate total damage
    public float CalculateTotalDamage(float damageAmount, float defenseAmount, float criticalHitChance)
    {
        // Calculate effective damage after applying defense
        float effectiveDamage = Mathf.Max(damageAmount - defenseAmount, 0) / criticalHitChance;

        // Determine if a critical hit occurs
        bool isCriticalHit = _random.NextDouble() < criticalHitChance;

        // If it's a critical hit, double the effective damage
        if (isCriticalHit)
        {
            effectiveDamage *= 2;
        }

        return effectiveDamage;
    }

    // Example usage in Unity
    private void Start()
    {
        float damage = 2;
        float defense = 1;
        float criticalHitChance = 0.25f; // 25% chance

        float totalDamage = CalculateTotalDamage(damage, defense, criticalHitChance);
        Debug.Log($"Total Damage: {totalDamage}");
    }
}
