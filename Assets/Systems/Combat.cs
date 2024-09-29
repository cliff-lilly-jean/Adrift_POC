using UnityEngine;

public class Combat : MonoBehaviour
{
    public float damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // TODO: Find a way to calculate damage based on a random number capped and the defense and armor stats
        collision.gameObject.GetComponent<Health>().ChangeHealth(-damage / 2);
    }
}