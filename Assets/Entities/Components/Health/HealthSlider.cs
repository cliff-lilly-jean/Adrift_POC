using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
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
    }

    private void UpdateHealthUI(float health)
    {
        // Update based on the health value received from the event
        healthSlider.value = health;
    }
}
