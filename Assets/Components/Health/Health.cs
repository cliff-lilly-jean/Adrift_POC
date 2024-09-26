using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public HealthData _healthData;

    // Start is called before the first frame update
    void Start()
    {
        _healthData._health = _healthData._healthMax;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
