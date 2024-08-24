using System.Collections.Generic;
using UnityEngine;

public abstract class Human : Entity {

    [SerializeField] private HumanStats _stats;
    [SerializeField] private List<Ability> _abilities;

    // Feeling [State], how you Feel affects your stats
    // ---- Fear, decreases strength
    // ---- Anxious, decreases speed
    // ---- Anger, increases strength
}