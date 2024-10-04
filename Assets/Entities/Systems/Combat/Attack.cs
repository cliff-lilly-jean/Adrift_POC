using TMPro;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public float damage;
    // public GameObject popUpPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // TODO: Find a way to calculate damage based on a random number capped and the defense and armor stats
        collision.gameObject.GetComponent<Health>().ChangeHealth(-damage);

        // GameObject popUp = Instantiate(popUpPrefab, collision.transform.position, Quaternion.identity);
        // popUp.GetComponentInChildren<TMP_Text>().text = damage.ToString();

    }
}