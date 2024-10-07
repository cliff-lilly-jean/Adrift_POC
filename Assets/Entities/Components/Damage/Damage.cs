using UnityEngine;
using TMPro;

public class Damage : MonoBehaviour
{
    public float damage;
    private Health targetHealth;
    private PopUpDamage popUpDamage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        var totalDamage =

        if (collision.gameObject.tag == "Entity")
        {
            if (targetHealth == null)
            {
                targetHealth = collision.gameObject.GetComponentInChildren<Health>();
            }

            targetHealth.TakeDamage(damage);
        }

    }
}