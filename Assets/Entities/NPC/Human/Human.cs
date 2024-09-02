using UnityEngine;
using System.Collections.Generic;

public abstract class Human : Entity {

    public HumanProperties properties;
    public MoveProperties move;


    // Feeling [State], how you Feel affects your stats
    // ---- Fear, decreases strength
    // ---- Anxious, decreases speed
    // ---- Anger, increases strength
}
