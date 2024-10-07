using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HealthData data;
    public Animator sliderFillAnim;

    // TODO: Setup an event system instead of using imports of the HealthData
    public delegate void HealthChangeEvent(float amount);
    public static HealthChangeEvent OnHealthChange;

    // Start is called before the first frame update
    void Start()
    {
        data.health = data.maxHealth;
    }

    public void TakeDamage(float amount)
    {
        data.health -= amount;
        sliderFillAnim.Play("SliderUpdate");

        if (data.health <= 0)
        {
            Destroy(gameObject);
        }

        // Trigger the health change event
        OnHealthChange?.Invoke(data.health);
    }
}
