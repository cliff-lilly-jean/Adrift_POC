using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopUpDamage : MonoBehaviour
{
    public Vector2 initialVelocity;
    public Rigidbody2D rb;
    public float lifetime = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = initialVelocity;
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
