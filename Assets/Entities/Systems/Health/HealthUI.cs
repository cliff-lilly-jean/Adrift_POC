using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public HealthStats healthStats;
    public Slider healthSlider;


    // Start is called before the first frame update
    void Start()
    {
        healthStats.health = healthStats.maxHealth;

        healthSlider.maxValue = healthStats.maxHealth;
        healthSlider.value = healthStats.health;

        // Subscribe to the OnHealthChange delegate
        Health.OnHealthChange += UpdateHealthUI;
    }

    private void OnDestroy()
    {
        Health.OnHealthChange -= UpdateHealthUI;
    }

    // Update is called once per frame
    void Update()
    {
        // for (int i = 0; i < hearts.Length; i++)
        // {
        //     if (healthStats.maxHealth > i)
        //     {
        //         hearts[i].enabled = true;
        //     }
        //     else
        //     {
        //         hearts[i].enabled = false;
        //     }
        // }
    }

    private void UpdateHealthUI(float health)
    {
        healthSlider.value = healthStats.health;
    }
}
