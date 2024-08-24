using System.Collections.Generic;
using UnityEngine;

public abstract class Human : Entity {

    [Header("Stats")]
    public HumanStats _stats;

    [Header("Abilities")]
    public List<Ability> _abilities;

    // Feeling [State], how you Feel affects your stats
    // ---- Fear, decreases strength
    // ---- Anxious, decreases speed
    // ---- Anger, increases strength
}