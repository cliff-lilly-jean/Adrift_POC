using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    public float currentStamina;
    public float maxStamina;

    // Start is called before the first frame update
    void Start()
    {
        currentStamina += maxStamina;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
