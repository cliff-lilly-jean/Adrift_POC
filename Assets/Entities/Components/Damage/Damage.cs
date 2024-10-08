using UnityEngine;
using TMPro;

public class Damage : MonoBehaviour
{
    public float damage;
    private Health targetHealth;


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Entity")
        {
            if (targetHealth == null)
            {
                targetHealth = collision.gameObject.GetComponentInChildren<Health>();
                Debug.Log("Entity Health");
            }

            targetHealth.TakeDamage(damage);
        }

    }

    // TODO: setup a way to take in account the defense, health and critical hit chance to calculate the damage
}