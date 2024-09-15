using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour
{
    [SerializeField] private StaminaData _data;

    // Start is called before the first frame update
    void Start()
    {
        _data.stamina = _data.staminaMax;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
