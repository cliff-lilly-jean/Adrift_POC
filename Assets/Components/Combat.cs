using UnityEngine;

public class Combat : MonoBehaviour
{
    public float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.gameObject.GetComponent<Health>().ChangeHealth(-damage / 2);
    }
}