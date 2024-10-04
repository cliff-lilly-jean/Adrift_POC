using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public HealthData data;
    public Slider healthSlider;


    // Start is called before the first frame update
    void Start()
    {
        data.health = data.maxHealth;

        healthSlider.maxValue = data.maxHealth;
        healthSlider.value = data.health;

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
        //     if (data.maxHealth > i)
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
        healthSlider.value = data.health;
    }
}
