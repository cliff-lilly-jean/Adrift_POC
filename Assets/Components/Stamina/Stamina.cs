using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    [SerializeField] private StaminaData _staminaData;

    // Start is called before the first frame update
    void Start()
    {
        _staminaData.stamina = _staminaData.staminaMax;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
