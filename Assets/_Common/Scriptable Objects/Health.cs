using UnityEngine;

[CreateAssetMenu(fileName = "Health", menuName = "Data/Health")]
public class Health : ScriptableObject {

    public float currentHealth;
    public float maxHealth;
}