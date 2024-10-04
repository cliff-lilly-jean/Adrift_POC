using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthDamagePopup : MonoBehaviour
{
    public Vector2 initialVelocity;
    public float lifetime = 1.5f;
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = initialVelocity;
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
