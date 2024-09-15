using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private HealthData _data;

    // Start is called before the first frame update
    void Start()
    {
        if (_data._health > _data._healthMax) { _data._health = _data._healthMax; }
        _data._health = _data._healthMax;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("This is the starting value of the health " + _data._health);
    }
}
