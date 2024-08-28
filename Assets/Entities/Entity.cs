using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour {

    public MoveProperties move;
    public HealthProperties health;
    public StaminaProperties stamina;

    public List<AbilityProperties> abilities;
}