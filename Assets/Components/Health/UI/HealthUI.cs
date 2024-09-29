using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{
    public HealthStats healthStats;

    public Sprite halfHeart;
    public Sprite fullHeart;
    public Image[] hearts;

    // Start is called before the first frame update
    void Start()
    {
        // Subscribe to the OnHealthChange delegate
        Health.OnHealthChange += UpdateHealthUI;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < hearts.Length; i++)
        {
            if (healthStats.maxHealth > i)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    private void UpdateHealthUI(float currentHealth)
    {
        Debug.Log("This is the current Health" + currentHealth);
    }
}
