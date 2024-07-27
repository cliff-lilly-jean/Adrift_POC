using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private MovementSystem _movementSystem;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_movementSystem.movementAbilities[0].description.value);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
